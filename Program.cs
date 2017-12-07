using System;

namespace ScratchGraphs
{
    class Program
    {
        static void checkList(LinkedList list)
        {
            if (list.head()== null)
            {
                System.Console.WriteLine("Null");
            } 
            else
            {
                System.Console.WriteLine(list.head().val);
            }
            System.Console.WriteLine(list.count());
            System.Console.WriteLine(list.isEmpty());
        }

        static void checkNode(LLNode node)
        {
            if (node.val == null)
            {
                System.Console.Write("Null"+ " ");
            }
            else
            {
                System.Console.Write(node.val + " ");
            }
            if (node.next == null)
            {
                System.Console.WriteLine("Null");
            } 
            else
            {
                System.Console.WriteLine(node.next);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LLNode newNode = new LLNode();
            checkNode(newNode);

            LLNode valNode = new LLNode(5);            
            checkNode(valNode);

            LinkedList newList = new LinkedList();
            newList.add(4);
            checkList(newList);
            newList.add(15);
            newList.add(10);
            System.Console.WriteLine(newList.Contains(4));
            System.Console.WriteLine(newList.Contains(10));

            LinkedList emptyList = new LinkedList();
            checkList(emptyList);
            System.Console.WriteLine(emptyList.Contains(4));
            System.Console.WriteLine(emptyList.Contains(null));
        }
    }
}
