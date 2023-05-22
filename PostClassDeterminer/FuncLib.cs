using System.Numerics;

namespace PostClassDeterminer
{
    internal static class FuncLib
    {
        // Check whether the number is a power of two
        public static bool IsPowerOfTwo(int num)
        {
            return (num > 0) && ((num & (num - 1)) == 0);
        }

        public static string BoolToSymbol(bool value)
        {
            if (value) return "+";
            else return "-";
        }

        public static bool NextCombination(int k, int[] curCombIndexesRef)
        {
            // Finds next combination of indexes, where
            // curCombIndexesRef - reference to current combination (sets the quantity of numbers in combination,
            // the last element should be the biggest possible)
            // k - parameter for A_k

            int p = k - 2;
            // The biggest possible value for current element (with array index p)
            int searchIndex = curCombIndexesRef[k - 1] - 1;
            // Find the rightmost index in curCombIndexes that can be increased
            while (curCombIndexesRef[p] >= searchIndex)
            {
                p--;
                // Points at biggest possible index for curCombIndexes[p]
                searchIndex--;
                if (p < 0) return false;
            }
            curCombIndexesRef[p]++;
            // Reset indexes to the right of curCombIndexes[p]
            for (int i = p + 1; i < k; i++)
            {
                curCombIndexesRef[i] = curCombIndexesRef[i - 1] + 1;
            }
            return true;
        }
    }
}
