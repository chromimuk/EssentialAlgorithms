using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EssentialAlgorithms.Arrays
{
    class ArrayAlgorithms
    {
        public static int IndexOf(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                    return i;
            }
            return -1;
        }

        public static int FindMinimum(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }
            return min;
        }

        public static int FindMaximum(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
        }

        public static double FindAverage(int[] array)
        {
            int total = 0;
            for (int i = 0; i < array.Length; i++)
            {
                total += array[i];
            }
            return total / array.Length;
        }

        public static void InsertItem(int[] array, int value, int pos)
        {
            Array.Resize(ref array, array.Length + 1);
            for (int i = array.Length - 1; i > pos + 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[pos] = value;
        }
    }
}
