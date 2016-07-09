namespace EssentialAlgorithms.Searching
{
    static class InterpolationSearch
    {
        public static int Searching(int[] array, int target)
        {
            int min = 0;
            int max = array.Length - 1;

            while (min <= max)
            {
                int mid = min + (max - min) * (target - array[min]) / (array[max] - array[min]);

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
