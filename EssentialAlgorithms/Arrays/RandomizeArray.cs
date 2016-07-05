using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EssentialAlgorithms.Arrays
{
    class Randomize
    {
        public static void RandomizeArray(int[] array)
        {
            int max = array.Length;

            for (int i = 0; i < max; i++)
            {
                int j = new Random().Next(i, max);
                int remainder = array[i];
                array[i] = array[j];
                array[j] = remainder;
            }
        }
    }
}
