namespace EssentialAlgorithms.LinkedLists
{
    public class SinglyIntegerCell
    {
        public int Value { get; set; }
        public SinglyIntegerCell Next { get; set; }

        public SinglyIntegerCell()
        {
            Value = int.MinValue;
            Next = null;
        }

        public SinglyIntegerCell(int v)
        {
            Value = v;
            Next = null;
        }

        public SinglyIntegerCell(int v, SinglyIntegerCell n)
        {
            Value = v;
            Next = n;
        }
    }
}
