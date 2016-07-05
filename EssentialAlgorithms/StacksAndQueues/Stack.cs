using EssentialAlgorithms.LinkedLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EssentialAlgorithms.StacksAndQueues
{
    class Stack : SinglyLinkedList
    {
        public void Push(int value)
        {
            SinglyIntegerCell newCell = new SinglyIntegerCell(value);
            newCell.Next = top;
            top = newCell;
        }

        public int Pop()
        {
            if (top == null)
                throw new Exception("Empty list");

            int value = top.Value;
            top = top.Next;
            return value;
        }

    }
}
