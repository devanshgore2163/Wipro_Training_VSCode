
class Program
{
    static void main(string[] args)
    {
        Stack stack = new Stack();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        Console.WriteLine("Enter the stack opeerations");

        object poppedvalue = Stack.Pop();
        Console.WriteLine("Popped value is"+poppedvalue);

        object topValue = Stack.Peek();
        Console.WriteLine("Top value of the stack is "+topValue);

        object countValue = Stack.Count();
        Console.WriteLine("Count is"+countValue);
    }
}