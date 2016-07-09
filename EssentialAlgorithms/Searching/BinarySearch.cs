namespace EssentialAlgorithms.Searching
{
    static class BinarySearch
    {
        public static int Searching(int[] array, int target)
        {
            int min = 0;
            int max = array.Length;

            while (min <= max)
            {
                int mid = (min + max) / 2;

                if (array[mid] == target)
                    return mid;

                else if (array[mid] > target)
                    max = mid - 1;
                else if (array[mid] < target)
                    min = mid + 1;
            }

            return -1;
        }
    }
}
