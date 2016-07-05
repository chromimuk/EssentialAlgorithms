namespace EssentialAlgorithms.LinkedLists
{
    public class DoublyLinkedListTesting
    {

        public static void Test()
        {
            DoublyLinkedList list = new DoublyLinkedList();

            list.AddAtBegining(new DoublyIntegerCell(3));
            list.AddAtBegining(new DoublyIntegerCell(2));
            list.AddAtBegining(new DoublyIntegerCell(1));
            list.AddAtTheEnd(new DoublyIntegerCell(4));
            list.AddAtTheEnd(new DoublyIntegerCell(5));

            list.Iterate();

            list.FindCell(3);
            list.FindCell(7);

            list.DeleteCell(3);
            list.DeleteCell(0);

            list.IterateReverse();
        }

    }

    class DoublyLinkedList
    {
        private DoublyIntegerCell top;
        private DoublyIntegerCell current;


        public void AddAtBegining(DoublyIntegerCell newCell)
        {
            if (top == null)
                top = newCell;

            else
            {
                top.Previous = newCell;
                newCell.Next = top;
                top = newCell;
            }
        }

        public void AddAtTheEnd(DoublyIntegerCell newCell)
        {
            if (top == null)
                top = newCell;

            else
            {
                current = top;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newCell;
                newCell.Previous = current;
            }
        }


        public void FindCell(int v)
        {
            current = top;
            while (current != null)
            {
                if (current.Value == v)
                {
                    System.Diagnostics.Debug.WriteLine("Cell " + v + " found");
                    return;
                }
                current = current.Next;
            }

            System.Diagnostics.Debug.WriteLine("Cell " + v + " not found");
        }
        
        public void DeleteCell(int v)
        {
            current = top;
            while (current.Next != null)
            {
                if (current.Next.Value == v)
                {
                    current.Next.Next.Previous = current.Next.Previous;
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }
        }

        public void Iterate()
        {
            current = top;
            while (current != null)
            {
                System.Diagnostics.Debug.WriteLine(current.Value);
                current = current.Next;
            }
        }

        public void IterateReverse()
        {
            current = top;
            while (current.Next != null)
            {
                current = current.Next;
            }

            while (current != null)
            {
                System.Diagnostics.Debug.WriteLine(current.Value);
                current = current.Previous;
            }
        }

    }
}
