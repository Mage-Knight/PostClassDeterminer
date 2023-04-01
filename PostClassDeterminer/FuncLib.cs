using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PostClassDeterminer
{
    internal static class FuncLib
    {
        // Check whether the number is a power of two
        public static bool IsPowerOfTwo(int num)
        {
            return (num > 0) && ((num & (num - 1)) == 0);
        }

        // Return all combinations of k element from set of elements
        public static IEnumerable<IEnumerable<T>> DifferentCombinations<T>(this IEnumerable<T> elements, int k)
        {
            return k == 0 ? new[] { Array.Empty<T>() } :
              elements.SelectMany((e, i) =>
                elements.Skip(i + 1).DifferentCombinations(k - 1).Select(c => (new[] { e }).Concat(c)));
        }

        // Converts IEnumerable<IEnumerable<int>> to int jagged array
        public static int[][] EnumerableToMatrix(this IEnumerable<IEnumerable<int>> enumer)
        {
            int combinationsNumber = enumer.Count();
            int[][] arr = new int[combinationsNumber][];
            for (int i = 0; i < combinationsNumber; i++)
            {
                arr[i] = enumer.ElementAt(i).ToArray();
            }

            return arr;
        }

        // Return all combinations of k element from set of elements v2.0
        public static int[,] Combinations(int[] numbers, int k)
        {
            if (numbers.Length < k) return (int[,])numbers.Clone();
            BigInteger numerator = 1;
            BigInteger denominator = 1;
            //int res = 1;
            for (int i = 0; i < k; i++)
            {
                numerator *= (numbers.Length - i);
                denominator *= (i + 1);
                //res *= (numbers.Length - k + i + 1) / (k - i);
            }
            int maxIndex = numbers.Length - 1;
            int searchIndex = numbers.Length - 2;
            int[] curCombIndexes = Enumerable.Range(0, k).ToArray();
            //int[,] allCombinations = new int[res, k];
            int[,] allCombinations = new int[(int)(numerator / denominator), k];
            int generalIndex = 0;
            bool flagStop = false;
            while (true)
            {

                while (curCombIndexes[k - 1] <= maxIndex)
                {
                    for (int j = 0; j < k; j++)
                    {
                        allCombinations[generalIndex, j] = numbers[curCombIndexes[j]];
                    }
                    generalIndex++;
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
                searchIndex = numbers.Length - 2;
                curCombIndexes[p]++;
                for (int i = p + 1; i < k; i++)
                {
                    curCombIndexes[i] = curCombIndexes[i - 1] + 1;
                }

            }
            return allCombinations;

        }
    
        public static string BoolToSymbol(bool value)
        {
            if (value) return "+";
            else return "-";
        }
    }
}
