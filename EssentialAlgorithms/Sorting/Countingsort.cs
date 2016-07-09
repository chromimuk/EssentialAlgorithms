using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EssentialAlgorithms.Sorting
{
    class Countingsort
    {
        public static void Sort(int[] array)
        {
            int maxValue = Arrays.ArrayAlgorithms.FindMaximum(array);
            int[] counts = new int[maxValue + 1];

            // count the item of each value
            for (int i = 0; i < array.Length; i++)
            {
                counts[array[i]]++;
            }

            // copy the values back into the array
            int index = 0;
            for (int i = 0; i <= maxValue; i++)
            {
                for (int j = 1; j <= counts[i]; j++)
                {
                    array[index] = i;
                    index++;
                }
            }

        }
    }
}
