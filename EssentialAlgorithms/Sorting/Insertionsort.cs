using System;

namespace EssentialAlgorithms.Sorting
{
    static class Insertionsort
    {
        public static void Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                // Move item i into position in the sorted part of the array.
                // < Find the first index j where j < i and values[j] > values[i].>
                // < Move the item into position j.>

                for (int j = 0; j < array.Length; j++)
                {
                    if (j < i && array[j] > array[i])
                    {
                        Arrays.ArrayAlgorithms.MoveWithinArray(array, i, j);
                    }
                }
            }
        }
    }
}
