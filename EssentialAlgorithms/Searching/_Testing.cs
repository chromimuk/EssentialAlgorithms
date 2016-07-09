namespace EssentialAlgorithms.Searching
{
    class _Testing
    {
        public static void Test()
        {
            int[] array = { 7, 4, 5, 1, 6, 3, 2, 8 };
            Sorting.Heapsort.Sort(array);

            int res = -1;
            int target = 5;

            res = LinearSearch.Searching(array, target);
            System.Diagnostics.Debug.WriteLine("Linear search: idx of {0} is {1}", target, res);

            res = BinarySearch.Searching(array, target);
            System.Diagnostics.Debug.WriteLine("Binary search: idx of {0} is {1}", target, res);

            res = InterpolationSearch.Searching(array, target);
            System.Diagnostics.Debug.WriteLine("Interpolation search: idx of {0} is {1}", target, res);
        }
    }
}
