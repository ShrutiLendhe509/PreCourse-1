using System;
// Time Complexity :O(1)
// Space Complexity :O(1)
public class StackAsLinkedList
{

    public StackNode root;

    public class StackNode
    {
        public int data;
        public StackNode next;

        public StackNode(int data)
        {
            //Constructor here 
            this.data = data;
            this.next = null;
        }
    }


    public bool IsEmpty()
    {
        //Write your code here for the condition if stack is empty. 
        return root == null;
    }

    public void push(int data)
    {
        //Write code to push data to the stack. 
        StackNode newNode = new StackNode(data);
        if(root == null) //if stack is empty
        {
            root = newNode;
            return;

        }
        newNode.next = root;
        root = newNode;


    }

    public int pop()
    {
        int peek = -1;
        //If Stack Empty Return 0 and print "Stack Underflow"
        // check for stack underflow
        if (root == null)
        {
            Console.Write("\nStack Underflow");
            return 0;
        }
        //Write code to pop the topmost element of stack.
        if (root != null)
        {
            peek = root.data;
            root = root.next;
        }
        //Also return the popped element 


        
        
        return peek;
    }

    public int peek()
    {
        //Write code to just return the topmost element without removing it.
        if (root == null)
        {
            Console.WriteLine("Stack Underflow.");
          //  return 0;
        }

       // Console.WriteLine("{0} is on the top of Stack", root.data);
        return root.data;
    }

    //Driver code
    public static void Main(String[] args)
    {

        StackAsLinkedList sll = new StackAsLinkedList();

        sll.push(10);
        sll.push(20);
        sll.push(30);

        Console.WriteLine(sll.pop() + " popped from stack");

        Console.WriteLine("Top element is " + sll.peek());
        Console.ReadLine();
    }
}
