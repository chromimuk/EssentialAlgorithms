namespace EssentialAlgorithms.Sorting
{
    public class _Testing
    {
        public static void Test()
        {
            int[] array = InitArray();
            Insertionsort.Sort(array);
            System.Diagnostics.Debug.WriteLine("Insertionsort: " + string.Join(" ", array));


            array = InitArray();
            Selectionsort.Sort(array);
            System.Diagnostics.Debug.WriteLine("Selectionsort: " + string.Join(" ", array));


            array = InitArray();
            Bubblesort.Sort(array);
            System.Diagnostics.Debug.WriteLine("Bubblesort: " + string.Join(" ", array));


            array = InitArray();
            Heapsort.Sort(array);
            System.Diagnostics.Debug.WriteLine("Heapsort: " + string.Join(" ", array));


            array = InitArray();
            Quicksort.Sort(array, 0, array.Length - 1);
            System.Diagnostics.Debug.WriteLine("Quicksort: " + string.Join(" ", array));


            array = InitArray();
            int[] scratch = new int[array.Length];
            Mergesort.Sort(array, scratch, 0, array.Length - 1);
            System.Diagnostics.Debug.WriteLine("Mergesort: " + string.Join(" ", array));

            array = InitArray();
            Countingsort.Sort(array);
            System.Diagnostics.Debug.WriteLine("Countingsort: " + string.Join(" ", array));
        }


        private static int[] InitArray()
        {
            return new int[] { 7, 4, 5, 1, 6, 3, 2, 8 };
        }
    }
}
