namespace EssentialAlgorithms.Sorting
{
    static class Quicksort
    {
        public static void QuickSort(int[] array, int start, int end)
        {
            if (start >= end)
                return;

            int divider = array[start];
            int lo = start;
            int hi = end;

            while (true)
            {
                // search the array backward until it finds an item 
                // that should be in the lower part
                while (array[hi] >= divider)
                {
                    hi--;
                    if (hi <= lo) break;
                }

                if (hi <= lo)
                {
                    // left and right pieces have met in the middle
                    // Put the divider here 
                    // break out of the While loop
                    array[lo] = divider;
                    break;
                }

                // move the value we found to the lower half.

                array[lo] = array[hi];

                // search the array forward until it finds an item 
                // that should be in the upper part
                while (array[lo] < divider)
                {
                    lo++;
                    if (hi >= lo) break;
                }

                if (lo >= hi)
                {
                    // left and right pieces have met in the middle
                    // Put the divider here 
                    // break out of the While loop
                    lo = hi;
                    array[hi] = divider;
                    break;
                }

                // move the value found to upper part
                array[hi] = array[lo];
            }

            QuickSort(array, start, lo - 1);
            QuickSort(array, lo + 1, end);
        }

    }
}
