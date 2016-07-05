namespace EssentialAlgorithms.Sorting
{
    public class _Testing
    {
        public static void Test()
        {
            int[] array = InitArray();
            Insertionsort.InsertionSort(array);
            System.Diagnostics.Debug.WriteLine("Insertionsort: " + string.Join(" ", array));


            array = InitArray();
            Selectionsort.SelectionSort(array);
            System.Diagnostics.Debug.WriteLine("Selectionsort: " + string.Join(" ", array));


            array = InitArray();
            Bubblesort.BubbleSort(array);
            System.Diagnostics.Debug.WriteLine("Bubblesort: " + string.Join(" ", array));


            array = InitArray();
            Heapsort.HeapSort(array);
            System.Diagnostics.Debug.WriteLine("Heapsort: " + string.Join(" ", array));


            array = InitArray();
            Quicksort.QuickSort(array, 0, array.Length - 1);
            System.Diagnostics.Debug.WriteLine("Quicksort: " + string.Join(" ", array));


            array = InitArray();
            int[] scratch = new int[array.Length];
            Mergesort.MergeSort(array, scratch, 0, array.Length - 1);
            System.Diagnostics.Debug.WriteLine("Mergesort: " + string.Join(" ", array));

            array = InitArray();
            Countingsort.CountingSort(array);
            System.Diagnostics.Debug.WriteLine("Countingsort: " + string.Join(" ", array));
        }


        private static int[] InitArray()
        {
            return new int[] { 7, 4, 5, 1, 6, 3, 2, 8 };
        }
    }
}
