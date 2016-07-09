namespace EssentialAlgorithms.Sorting
{
    static class Bubblesort
    {
        public static void Sort(int[] array)
        {
            bool isSorted = false;

            while (!isSorted)
            {
                isSorted = true;

                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < array[i - 1])
                    {
                        int tmp = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = tmp;

                        isSorted = false;
                    }
                }
            }
        }
    }
}
