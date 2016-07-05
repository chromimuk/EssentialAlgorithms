using System.Text;

namespace EssentialAlgorithms.LinkedLists
{

    public class SinglyLinkedListTesting {

        public static void Test()
        {
            SinglyLinkedList list = new SinglyLinkedList();

            list.AddAtBegining(new SinglyIntegerCell(1));
            list.AddAtBegining(new SinglyIntegerCell(3));
            list.AddAtBegining(new SinglyIntegerCell(5));
            list.AddAtTheEnd(new SinglyIntegerCell(4));
            list.AddAtTheEnd(new SinglyIntegerCell(2));

            list.Iterate();

            list.FindCell(3);
            list.FindCell(7);
            list.DeleteCell(3);
            list.DeleteCell(0);
            list.Iterate();

            list.SelectionSort();
            list.Iterate();

            list.Reverse();
            list.Iterate();


            var loopedList = new SinglyLinkedList();
            var a = new SinglyIntegerCell(-1, null);
            var b = new SinglyIntegerCell(1, a);
            var c = new SinglyIntegerCell(1, b);
            a.Next = b;
            b.Next = c;
            loopedList.AddAtBegining(c);
            loopedList.AddAtBegining(b);
            loopedList.AddAtBegining(a);
            loopedList.Iterate();

            var res = loopedList.HasLoop();
        }

    }


    public class SinglyLinkedList
    {
        public SinglyIntegerCell top { get; set; }
        public SinglyIntegerCell current { get; set; }

        public void AddAtBegining(SinglyIntegerCell newCell)
        {
            if (top == null)
                top = newCell;

            else
            {
                newCell.Next = top;
                top = newCell;
            }
        }
        
        public void AddAtTheEnd(SinglyIntegerCell newCell)
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

            if (current.Value == v)
            {
                top = top.Next;
                return;
            }

            while (current.Next != null)
            {
                if (current.Next.Value == v)
                {
                    current.Next = current.Next.Next;
                    System.Diagnostics.Debug.WriteLine("Cell " + v + " removed");
                    return;
                }
                current = current.Next;
            }
        }
        
        public SinglyLinkedList Copy()
        {
            SinglyLinkedList newList = new SinglyLinkedList();
            SinglyIntegerCell newTop = new SinglyIntegerCell(top.Value);

            current = top;

            while (current != null)
            {
                newList.AddAtTheEnd(new SinglyIntegerCell(current.Value));
                current = current.Next;
            }

            return newList;
        }
        
        public void SelectionSort()
        {
            SinglyLinkedList newList = new SinglyLinkedList();
            SinglyIntegerCell tmpCell = new SinglyIntegerCell();
            SinglyIntegerCell bestAfterMe, afterMe, bestCell;

            current = new SinglyIntegerCell(int.MinValue, top);

            while (current.Next != null)
            {
                // find largest item in the list
                bestAfterMe = current;
                int bestValue = current.Next.Value;

                afterMe = current.Next;
                while (afterMe.Next != null)
                {
                    if (afterMe.Next.Value > bestValue)
                    {
                        bestAfterMe = afterMe;
                        bestValue = afterMe.Next.Value;
                    }
                    afterMe = afterMe.Next;
                }

                // remove best cell from unsorted list
                bestCell = bestAfterMe.Next;
                bestAfterMe.Next = bestCell.Next;

                bestCell.Next = tmpCell.Next;
                tmpCell.Next = bestCell;
            }

            top = tmpCell.Next;
        }
        
        public void Reverse()
        {
            SinglyIntegerCell previous, next;
            previous = null;
            current = top;

            while (current != null)
            {
                next = current.Next;
                current.Next = previous;

                previous = current;
                current = next;
            }

            top = previous;
        }
        
        public bool HasLoop()
        {
            if (top.Next == null)
                return false;

            SinglyIntegerCell a, b;
            a = top;
            Reverse();
            b = top;
            Reverse();

            if (a == b)
                return true;
            else
                return false;
        }

        public void Iterate()
        {
            if (HasLoop())
            {
                System.Diagnostics.Debug.WriteLine("The list will loop until the end of time!");
            }
            else
            {
                StringBuilder sb = new StringBuilder();

                int count = 0;
                current = top;
                while (current != null)
                {
                    sb.AppendFormat("{0} ", current.Value);
                    count++;
                    current = current.Next;
                }

                sb.Insert(0, count + " elements in the list: ");
                System.Diagnostics.Debug.WriteLine(sb);
            }
        }

    }
}
