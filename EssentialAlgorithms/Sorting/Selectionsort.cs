using System;

namespace EssentialAlgorithms.Sorting
{
    static class Selectionsort
    {
        public static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                // Find the item that belongs in position i.
                // < Find the smallest item with index j >= i.>
                // < Swap values[i] and values[j].>

                int minimum = array[i];
                int posMinimum = i;

                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] < minimum)
                    {
                        minimum = array[j];
                        posMinimum = j;
                    }
                }

                if (posMinimum != i)
                    Arrays.ArrayAlgorithms.MoveWithinArray(array, posMinimum, i);
            }
        }
    }
}
