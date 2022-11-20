// Time Complexity :O(n)
// Space Complexity :O(1)
public class Stack
{
    //Please read sample.java file before starting.
    //Kindly include Time and Space complexity at top of each file
    static int MAX = 1000;
    int top;
    private int[] element = new int[MAX]; // Maximum size of Stack 

    public bool isEmpty()
    {
        return (top < 0);
    }

    public Stack()
    {
        //Initialize your constructor
        top = -1;
    }

    public bool push(int x)
    {
        //Check for stack Overflow
        if (top == MAX - 1)
        {
            Console.WriteLine("Stack overflow");
            return false;
        }
        else
        {
            element[++top] = x;
            return true;
        }
    }

    public int pop()
    {
        //If empty return 0 and print " Stack Underflow"
        if (top == -1)
        {
            Console.WriteLine("Stack Underflow");
            return -1;

        }
        else
        {
            Console.WriteLine($"Popped element is:{element[top]}");
            return element[top--];
        }
    }

    public void Peek()
    {
        if (top < 0)
        {
            Console.WriteLine("Stack Underflow");

            return;
        }
        else
        {
            Console.WriteLine($"Top most element in:{element[top]}");

        }
    }

    public void PrintStack()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is Empty");
        }
        else
        {
            for (int i = 0; i <= top; i++)
            {
                Console.WriteLine($"Item[{i + 1}] : {element[i]}");
            }
        }
    }
}
public class Program
{
    static void Main(string[] args)
    {

        Stack s = new Stack();
        s.push(10);
        s.push(20);
        s.push(30);
        Console.WriteLine("Items are : ");
        s.PrintStack();
        s.Peek();
        Console.WriteLine(s.pop() + " Popped from stack");
        Console.ReadLine();

    }
}
