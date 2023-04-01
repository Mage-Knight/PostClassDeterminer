using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using static PostClassDeterminer.PostLattice;

namespace PostClassDeterminer
{
    internal class BooleanFunction
    {

        public int[] ValuesVector { get; set; }
        public int N { get; set; }
        public BooleanFunction DualFunc { get; set; }
        public PostLattice Lattice { get; set; }
        public bool[] FlagAndIsM { get; set; } = new bool[] { false, false };
        public bool[] FlagAndIsS { get; set; } = new bool[] { false, false };
        public bool[] FlagAndIsL { get; set; } = new bool[] { false, false };

        // Regular expression to match the input pattern and check
        // whether the className belongs to one of eight infinite families
        private static readonly string patternCheck = @"^((a|Ma)(0)?|(A|MA)(1)?)_([2-9]|[1-9][0-9]+)$";

        public BooleanFunction(int[] valuesVector)
        {
            N = (int)Math.Log2(valuesVector.Length);
            int newN = N;
            int iterWithDelete = 0;
            int startIndex, endIndex;
            bool flagSignificantVar = false;
            int[] valuesVectorCopy = new int[valuesVector.Length];
            Array.Copy(valuesVector, valuesVectorCopy, valuesVector.Length);
            List<int> delIndexArray = new();

            for (int i = 0; i < N; i++)
            {

                for (int j = 0; j < (int)Math.Pow(2, N - i - 1); j++)
                {

                    for (int k = 0; k < (int)Math.Pow(2, i - iterWithDelete); k++)
                    {
                        startIndex = j * (int)Math.Pow(2, i + 1 - iterWithDelete) + k;
                        endIndex = startIndex + (int)Math.Pow(2, i - iterWithDelete);
                        delIndexArray.Add(endIndex);
                        if (valuesVectorCopy[startIndex] != valuesVectorCopy[endIndex])
                        {
                            flagSignificantVar = true;
                            break;
                        }
                    }

                    if (flagSignificantVar) break;

                }

                if (!flagSignificantVar)
                {
                    valuesVectorCopy = valuesVectorCopy.Where((val, idx) => delIndexArray.Contains(idx)).ToArray();
                    newN--;
                    iterWithDelete++;
                }
                else
                {
                    flagSignificantVar = false;
                }
                delIndexArray = new();

            }

            ValuesVector = new int[valuesVectorCopy.Length];
            Array.Copy(valuesVectorCopy, ValuesVector, valuesVectorCopy.Length);
            N = newN;
            Lattice = new(Math.Max(N, 2));
            DualFunc = new(this, FindDual(ValuesVector), N);

        }

        public BooleanFunction(BooleanFunction dualPointer, int[] valuesVector, int n)
        {
            ValuesVector = new int[valuesVector.Length];
            Array.Copy(valuesVector, ValuesVector, valuesVector.Length);
            N = n;
            DualFunc = dualPointer;
            Lattice = dualPointer.Lattice;
        }

        public bool IsT0()
        {
            if (ValuesVector[0] == 0) return true;
            else return false;
        }

        public bool IsT1()
        {
            return DualFunc.IsT0();
        }

        public bool IsT01()
        {
            return IsT0() && IsT1();
        }

        public bool IsM()
        {
            if (FlagAndIsM[0]) return FlagAndIsM[1];
            else
            {
                FlagAndIsM[0] = true;

                int startIndex, endIndex;

                for (int i = 0; i < N; i++)
                {

                    for (int j = 0; j < (int)Math.Pow(2, N - i - 1); j++)
                    {

                        for (int k = 0; k < (int)Math.Pow(2, i); k++)
                        {
                            startIndex = j * (int)Math.Pow(2, i + 1) + k;
                            endIndex = startIndex + (int)Math.Pow(2, i);

                            if (ValuesVector[startIndex] > ValuesVector[endIndex])
                            {
                                FlagAndIsM[1] = false;
                                return false;
                            }
                        }
                    }
                }

                FlagAndIsM[1] = true;
                return true;

            }
        }

        public bool IsM0()
        {
            return IsM() && IsT0();
        }

        public bool IsM1()
        {
            return IsM() && DualFunc.IsT0();
        }

        public bool IsM01()
        {
            return IsM() && IsT01();
        }

        public bool IsS()
        {
            if (FlagAndIsS[0]) return FlagAndIsS[1];
            else
            {
                FlagAndIsS[0] = true;

                if (ValuesVector.Length == 1)
                {
                    FlagAndIsS[1] = false;
                    return false;
                }

                for (int i = 0; i < ValuesVector.Length / 2; i++)
                {
                    if (ValuesVector[i] == ValuesVector[ValuesVector.Length - i - 1])
                    {
                        FlagAndIsS[1] = false;
                        return false;
                    }
                }

                FlagAndIsS[1] = true;
                return true;
            }
        }
    
        public bool IsS01()
        {
            return IsS() && IsT01();
        }
            
        public bool IsSM()
        {
            return IsS() && IsM();
        }
    
        public bool IsL()
        {
            if (FlagAndIsL[0]) return FlagAndIsL[1];
            else
            {
                FlagAndIsL[0] = true;

                if (N <= 1)
                {
                    FlagAndIsL[1] = true;
                    return true;
                }

                int startIndex, endIndex;
                int[] valuesVectorCopy = new int[ValuesVector.Length];
                Array.Copy(ValuesVector, valuesVectorCopy, ValuesVector.Length);

                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < (int)Math.Pow(2, N - i - 1); j++)
                    {

                        for (int k = 0; k < (int)Math.Pow(2, i); k++)
                        {

                            startIndex = j * (int)Math.Pow(2, i + 1) + k;
                            endIndex = startIndex + (int)Math.Pow(2, i);
                            valuesVectorCopy[endIndex] ^= valuesVectorCopy[startIndex];

                        }

                    }
                }

                valuesVectorCopy = valuesVectorCopy.Where((val, idx) => !FuncLib.IsPowerOfTwo(idx) && idx != 0 && val == 1).ToArray();

                if (valuesVectorCopy.Length != 0) {
                    FlagAndIsL[1] = false;
                    return false; 
                }
                else
                {
                    FlagAndIsL[1] = true;
                    return true;
                }
            }

        }

        public bool IsLS()
        {
            return IsL() && IsS();
        }

        public bool IsL0()
        {
            return IsL() && IsT0();
        }

        public bool IsL1()
        {
            return IsL() && DualFunc.IsT0();
        }

        public bool IsL01()
        {
            return IsL() && IsT01();
        }

        public bool IsE0()
        {
            return ValuesVector.SequenceEqual(new int[] { 0 });
        }

        public bool IsE1()
        {
            return DualFunc.IsE0();
        }

        public bool IsE()
        {
            return IsE0() || IsE1();
        }

        public bool IsO01()
        {
            return ValuesVector.SequenceEqual(new int[] { 0, 1 });
        }

        public bool IsO0()
        {
            return IsE0() || IsO01();
        }

        public bool IsO1()
        {
            return DualFunc.IsO0();
        }

        public bool IsOS()
        {
            return IsO01() || ValuesVector.SequenceEqual(new int[] { 1, 0 });
        }

        public bool IsOM()
        {
            return IsO0() || IsO1();
        }

        public bool IsO()
        {
            return IsE() || IsOS();
        }

        public bool IsP01()
        {

            if (ValuesVector[^1] == 1 && !IsE1())
            {
                bool allZeroesBeforeLast = true;
                for (int i = 0; i < ValuesVector.Length - 1; i++)
                {
                    if (ValuesVector[i] != 0)
                    {
                        allZeroesBeforeLast = false;
                        break;
                    }
                }

                return allZeroesBeforeLast;

            }

            return false;
        }

        public bool IsP0()
        {
            return IsP01() || IsE0();
        }

        public bool IsP1()
        {
            return IsP01() || IsE1();
        }

        public bool IsP()
        {
            return IsP01() || IsE0() || IsE1();
        }

        public bool IsP01_d()
        {
            return DualFunc.IsP01();
        }

        public bool IsP0_d()
        {
            return DualFunc.IsP0();
        }

        public bool IsP1_d()
        {
            return DualFunc.IsP1();
        }

        public bool IsP_d()
        {
            return DualFunc.IsP();
        }

        public bool IsA_k(int k)
        {
            // No sense in checking for k > N, because A_N == A_inf
            if (k >= 2)
            {
                if (IsE0()) return true;
                else if (IsE1() || !IsT0()) return false;
                else if (k <= N)
                {
                    // Create array of index at which function == 1
                    int[] oneValueIndexes = ValuesVector.Select((val, idx) => new { Value = val, Index = idx })
                        .Where(x => x.Value == 1)
                        .Select(x => x.Index)
                        .ToArray();

                    // Find all combinations of k elements from these indexes
                    //var enumerableCombinations = indexes.DifferentCombinations(k);
                    //int[][] combinations = enumerableCombinations.EnumerableToMatrix();
                    if (oneValueIndexes.Length < k) return !NoJointOne(oneValueIndexes);

                    int maxIndex = oneValueIndexes.Length - 1;
                    int searchIndex = oneValueIndexes.Length - 2;
                    int[] curCombIndexes = Enumerable.Range(0, k).ToArray();
                    int[] curCombValues = new int[k];
                    bool flagStop = false;

                    while (true)
                    {

                        while (curCombIndexes[k - 1] <= maxIndex)
                        {
                            for (int j = 0; j < k; j++)
                            {
                                curCombValues[j] = oneValueIndexes[curCombIndexes[j]];
                            }
                            if (NoJointOne(curCombValues)) return false;
                            curCombIndexes[k - 1]++;
                        }
                        int p = k - 2;
                        while (!flagStop && curCombIndexes[p] >= searchIndex)
                        {
                            p--;
                            searchIndex--;
                            if (p < 0) flagStop = true;
                        }
                        if (flagStop) break;
                        searchIndex = oneValueIndexes.Length - 2;
                        curCombIndexes[p]++;
                        for (int i = p + 1; i < k; i++)
                        {
                            curCombIndexes[i] = curCombIndexes[i - 1] + 1;
                        }

                    }
                    //int[,] combinations = FuncLib.Combinations(indexes, k);
                    ////int[,,] argValues = new int[combinations.Length, k, N];
                    //string tempString;

                    //for (int i = 0; i < combinations.Length; i++)
                    //{
                    //    // Create initial vector of ones of length N
                    //    int[] combAndRes = Enumerable.Repeat(1, N).ToArray();
                    //    for (int j = 0; j < k; j++)
                    //    {
                    //        // Convert index to binary number
                    //        // This represents values of function arguments
                    //        tempString = Convert.ToString(combinations[i, j], 2).PadLeft(N, '0');

                    //        // Perform element-wise & operation to vectors of argugemnt values
                    //        for (int p = 0; p < N; p++)
                    //        {
                    //            combAndRes[p] *= int.Parse(tempString.Substring(p, 1));
                    //        }
                    //    }

                    //    // If there is no joint '1' -> return false
                    //    if (Array.TrueForAll(combAndRes, element => element == 0)) return false;
                    //}
                }

                return true;

            }

            else throw new Exception("k > N");
        }
    
        public bool NoJointOne(int[] indexes)
        {
            // Create initial vector of ones of length N
            int[] combAndRes = Enumerable.Repeat(1, N).ToArray();
            string tempString;

            for (int j = 0; j < indexes.Length; j++)
            {
                // Convert index to binary number
                // This represents values of function arguments
                tempString = Convert.ToString(indexes[j], 2).PadLeft(N, '0');

                // Perform element-wise & operation to vectors of argugemnt values
                for (int p = 0; p < N; p++)
                {
                    combAndRes[p] *= int.Parse(tempString.Substring(p, 1));
                }
            }

            // If there is no joint '1' -> return true
            return Array.TrueForAll(combAndRes, element => element == 0);
        }

        public bool IsMA_k(int k)
        {
            return IsM() && IsA_k(k);
        }

        public bool IsA1_k(int k)
        {
            return IsT1() && IsA_k(k);
        }

        public bool IsMA1_k(int k)
        {
            return IsM() && IsA1_k(k);
        }

        public bool Is_a_k(int k)
        {
            return DualFunc.IsA_k(k);
        }

        public bool IsMa_k(int k)
        {
            return DualFunc.IsMA_k(k);
        }

        public bool Is_a0_k(int k)
        {
            return DualFunc.IsA1_k(k);
        }

        public bool IsMa0_k(int k)
        {
            return DualFunc.IsMA1_k(k);
        }

        public static int[] FindDual(int[] func)
        {
            if (func.Length == 1) return new int[1] { func[0] ^ 1 };
            else
            {
                int temp;
                int[] funcCopy = new int[func.Length];
                Array.Copy(func, funcCopy, func.Length);

                for (int i = 0; i < funcCopy.Length / 2; i++)
                {
                    temp = funcCopy[i];
                    funcCopy[i] = 1 - funcCopy[funcCopy.Length - i - 1];
                    funcCopy[funcCopy.Length - i - 1] = 1 - temp;
                }

                return funcCopy;

            }
        }   
    
        public string[] FindNarrowestClasses()
        {
            List<string> nodesList = Lattice.SortedParentCount.ToList();
            for (int i = 0; i < nodesList.Count; i++)
            {
                if (BelongsToCLass(nodesList[i]))
                {
                    nodesList.RemoveAll(elem => Lattice.Elements[nodesList[i]].AllParents.Contains(elem));

                    // If the node belongs to one of 8 infinite families
                    // and k == N we replace k with "inf"
                    if (Regex.IsMatch(nodesList[i], patternCheck) && Int32.Parse(nodesList[i].Split('_')[1]) == N)
                    {
                        nodesList[i] = nodesList[i].Split('_')[0] + "_inf";
                    }

                }
                else
                {
                    nodesList.RemoveAt(i);
                    i--;
                }
            }
            return nodesList.ToArray();
        }

        // Check if this belongs to Post's class className
        public bool BelongsToCLass(string className)
        {

            if (Regex.IsMatch(className, patternCheck))
            {
                // Extract the number from the input
                int number = int.Parse(className.Split('_')[1]); 
                if (className.StartsWith("a_"))
                {
                    return Is_a_k(number);
                }
                else if (className.StartsWith("a0_"))
                {
                    return Is_a0_k(number);
                }
                else if (className.StartsWith("Ma_"))
                {
                    return IsMa_k(number);
                }
                else if (className.StartsWith("Ma0_"))
                {
                    return IsMa0_k(number);
                }
                else if (className.StartsWith("A_"))
                {
                    return IsA_k(number);
                }
                else if (className.StartsWith("A1_"))
                {
                    return IsA1_k(number);
                }
                else if (className.StartsWith("MA_"))
                {
                    return IsMA_k(number);
                }
                else if (className.StartsWith("MA1_"))
                {
                    return IsMA1_k(number);
                }
            }

            return className switch
            {
                "E0" => IsE0(),
                "E1" => IsE1(),
                "E" => IsE(),
                "O01" => IsO01(),
                "O0" => IsO0(),
                "O1" => IsO1(),
                "OS" => IsOS(),
                "OM" => IsOM(),
                "O" => IsO(),
                "P01" => IsP01(),
                "P0" => IsP0(),
                "P1" => IsP1(),
                "P" => IsP(),
                "P01_d" => IsP01_d(),
                "P0_d" => IsP0_d(),
                "P1_d" => IsP1_d(),
                "P_d" => IsP_d(),
                "L01" => IsL01(),
                "L0" => IsL0(),
                "L1" => IsL1(),
                "LS" => IsLS(),
                "L" => IsL(),
                "SM" => IsSM(),
                "S01" => IsS01(),
                "S" => IsS(),
                "M01" => IsM01(),
                "M0" => IsM0(),
                "M1" => IsM1(),
                "M" => IsM(),
                "T01" => IsT01(),
                "T0" => IsT0(),
                "T1" => IsT1(),
                "P2" => true,
                _ => throw new Exception($"Post's class {className} not found"),
            };

        }

    }
}
