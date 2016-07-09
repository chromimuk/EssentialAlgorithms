namespace EssentialAlgorithms.Sorting
{
    static class Mergesort
    {
        public static void Sort(int[] array, int[] scratch, int start, int end)
        {
            if (start == end)
                return;

            int midPoint = (start + end) / 2;

            Sort(array, scratch, start, midPoint);
            Sort(array, scratch, midPoint + 1, end);


            // Merge the two sorted halves
            int leftIndex = start;
            int rightIndex = midPoint + 1;
            int scratchIndex = leftIndex;

            while (leftIndex <= midPoint && rightIndex <= end)
            {
                if (array[leftIndex] <= array[rightIndex])
                {
                    scratch[scratchIndex] = array[leftIndex];
                    leftIndex++;
                }
                else
                {
                    scratch[scratchIndex] = array[rightIndex];
                    rightIndex++;
                }
                scratchIndex++;
            }

            // Finish copying whichever half is not empty
            for (int i = leftIndex; i <= midPoint; i++)
            {
                scratch[scratchIndex] = array[i];
                scratchIndex++;
            }
            for (int i = rightIndex; i <= end; i++)
            {
                scratch[scratchIndex] = array[i];
                scratchIndex++;
            }

            // Copy the values back in the original array
            for (int i=start; i<=end; i++)
            {
                array[i] = scratch[i];
            }

        }


    }
}
