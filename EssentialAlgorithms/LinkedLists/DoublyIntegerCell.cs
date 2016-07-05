namespace EssentialAlgorithms.LinkedLists
{
    public class DoublyIntegerCell
    {
        public int Value { get; set; }
        public DoublyIntegerCell Next { get; set; }
        public DoublyIntegerCell Previous { get; set; }

        public DoublyIntegerCell(int v)
        {
            Value = v;
            Next = null;
            Previous = null;
        }

        public DoublyIntegerCell(int v, DoublyIntegerCell n, DoublyIntegerCell p)
        {
            Value = v;
            Next = n;
            Previous = p;
        }
    }
}
