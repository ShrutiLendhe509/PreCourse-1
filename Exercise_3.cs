// a Singly Linked List 
// Time Complexity :O(n)
// Space Complexity :O(n)

public class LinkedList
{

    public Node head; // head of list 

    // Linked list Node. 
  
    public class Node
    {

       public int data;
       public Node next;

        // Constructor 
        public Node(int d)
        {
            //Write your code here 
            this.data = d;
            this.next = null;
        }
    }

    // Method to insert a new node 
    public static LinkedList insert(LinkedList list, int data)
    {
        // Create a new node with given data 
        Node newNode = new Node(data);
        // If the Linked List is empty, 
        // then make the new node as head 
        if(list.head == null)
        {
            list.head = newNode;            
        }
        // Else traverse till the last node 
        // and insert the new_node there 
        else
        {
            Node lastNode = GetLastNode(list);
            lastNode.next = newNode;  // Add new node as the next node to the last node.

            
        }
        return list;
        // Insert the new_node at last node 
        // Return the list by head 

    }

    public static Node GetLastNode(LinkedList singlyList)
    {
        Node temp = singlyList.head;
        while (temp.next != null)
        {
            temp = temp.next;
        }
        return temp;
    }

    // Method to print the LinkedList. 
    public static void printList(LinkedList list)
    {

       // Node lastNode = GetLastNode(list);
        // Traverse through the LinkedList 
        Node temp = list.head;
        while (temp.next != null)
        {
            Console.WriteLine($"The current node data:{temp.data}");// Print the data at current node 

            temp = temp.next;   // Go to next node 
        }
    }

    // Driver code 
    public static void Main(String[] args)
    {
        /* Start with the empty list. */
        LinkedList list = new LinkedList();

        // 
        // ******INSERTION****** 
        // 

        // Insert the values 
        list = insert(list, 1);
        list = insert(list, 2);
        list = insert(list, 3);
        list = insert(list, 4);
        list = insert(list, 5);

        // Print the LinkedList 
        printList(list);
        Console.ReadLine();
    }
}