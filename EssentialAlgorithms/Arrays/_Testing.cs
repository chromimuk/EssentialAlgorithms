using EssentialAlgorithms.Arrays;

namespace EssentialAlgorithms
{
    public class ArrayTesting
    {
        public static void Test()
        {
            int[] array = { 5, 3, 1, 4, 2 };

            Randomize.RandomizeArray(array);

            int idx = ArrayAlgorithms.IndexOf(array, 1);
            int min = ArrayAlgorithms.FindMinimum(array);
            int max = ArrayAlgorithms.FindMaximum(array);
            double avg = ArrayAlgorithms.FindAverage(array);

            ArrayAlgorithms.InsertItem(array, 9, 3);
        }
    }
        
}
