namespace EssentialAlgorithms.Searching
{
    static class LinearSearch
    {
        // Find the target's index in a sorted array
        public static int Searching(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target) return i;
                if (array[i] > target) return -1;
            }
            return -1;
        }
    }
}
