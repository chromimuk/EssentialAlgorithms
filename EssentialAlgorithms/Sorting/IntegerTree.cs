using System;

namespace EssentialAlgorithms.Sorting
{
    class IntegerTree
    {
        private int[] Tree { get; set; }

        public IntegerTree(int[] t)
        {
            Tree = t;
        }

        public int Count()
        {
            return Tree.Length;
        }

        public int GetValueAt(int index)
        {
            return Tree[index];
        }

        public void SetValueAt(int index, int value)
        {
            Tree[index] = value;
        }


        public int[] GetChildrenIndices(int index)
        {
            int[] children = { -1, -1 };

            if (index >= 0 && index <= Tree.Length)
            {
                try
                {
                    children[0] = (2 * index + 1 < Tree.Length) ? 2 * index + 1 : -1;
                    children[1] = (2 * index + 2 < Tree.Length) ? 2 * index + 2 : -1;
                }
                catch (IndexOutOfRangeException)
                {
                    System.Diagnostics.Debug.WriteLine(Tree[index] + " is childless");
                }
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Index Out Of Range");
            }

            return children;
        }

        public int GetParentIndex(int index)
        {
            int parent = -1;

            if (index >= 0 && index <= Tree.Length)
            {
                try
                {
                    parent = (index - 1) / 2;
                }
                catch (IndexOutOfRangeException)
                {
                    System.Diagnostics.Debug.WriteLine(Tree[index] + " is parentless");
                }
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Index Out Of Range");
            }

            return parent;
        }


        public void MakeHeap()
        {
            for (int i = 0; i < Tree.Length; i++)
            {
                int index = i;

                while (index != 0)
                {
                    int parent = GetParentIndex(index);

                    if (Tree[index] <= Tree[parent])
                        break;

                    int tmp = Tree[index];
                    Tree[index] = Tree[parent];
                    Tree[parent] = tmp;

                    index = parent;
                }
            }
        }

        public bool IsHeap()
        {
            for (int i = 0; i < Tree.Length; i++)
            {
                int[] children = GetChildrenIndices(i);

                if ((children[0] > -1 && Tree[children[0]] > Tree[i]) || (children[1] > -1 && Tree[children[1]] > Tree[i]))
                    return false;
            }

            return true;
        }

    }
}
