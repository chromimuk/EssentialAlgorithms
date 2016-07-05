namespace EssentialAlgorithms.StacksAndQueues
{
    public class _Testing
    {
        public static void Test()
        {
            Stack stack = new Stack();
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);
            stack.Iterate();

            int res = stack.Pop();
            stack.Iterate();
        }
    }
}
