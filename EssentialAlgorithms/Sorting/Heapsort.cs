namespace EssentialAlgorithms.Sorting
{
    class Heapsort
    {
        public static void HeapSort(int[] array)
        {
            IntegerTree tree = new IntegerTree(array);
            tree.MakeHeap();

            int count = tree.Count() - 1;
            int swapTopLast, index, child1, child2, maxChild, swapTopChild;
            int[] children;

            for (int i = count; i >= 0; i--)
            {
                // swap top and last
                swapTopLast = tree.GetValueAt(0);
                tree.SetValueAt(0, tree.GetValueAt(i));
                tree.SetValueAt(i, swapTopLast);

                index = 0;

                // make tree heap again!
                while (true)
                {
                    // get child with max value
                    children = tree.GetChildrenIndices(index);
                    child1 = (children[0] >= 0 && children[0] < i) ? children[0] : index;
                    child2 = (children[1] >= 0 && children[1] < i) ? children[1] : index;
                    maxChild = (tree.GetValueAt(child1) >= tree.GetValueAt(child2)) ? child1 : child2;

                    // new top is < to one of its child so we swap them
                    if (tree.GetValueAt(maxChild) > tree.GetValueAt(index))
                    {
                        swapTopChild = tree.GetValueAt(index);
                        tree.SetValueAt(index, tree.GetValueAt(maxChild));
                        tree.SetValueAt(maxChild, swapTopChild);
                    }
                    else
                        break;

                    index = maxChild;
                }

            }
        }
    }
}
