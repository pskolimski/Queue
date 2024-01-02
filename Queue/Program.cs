using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class Program
    {
        public class IntegerQueue
        {
            private class Node
            {
                public int Value { get; set; }
                public Node Next { get; set; }

                public Node(int value)
                {
                    Value = value;
                    Next = null;
                }
            }

            private Node first;
            private Node last;

            public void AddLast(int value)
            {
                Node newNode = new Node(value);

                if (last == null)
                {
                    first = newNode;
                    last = newNode;
                }
                else
                {
                    last.Next = newNode;
                    last = newNode;
                }
            }

            public int GetFirst()
            {
                if (first == null)
                {
                    Console.WriteLine("Kolejka jest pusta");
                }

                int result = first.Value;
                first = first.Next;

                if (first == null)
                {
                    last = null;
                }

                return result;
            }

            public override string ToString()
            {
                Node current = first;
                string result = "";

                while (current != null)
                {
                    result += current.Value + " ";
                    current = current.Next;
                }

                return result.TrimEnd();
            }
        }

        static void Main(string[] args)
        {
            IntegerQueue queue = new IntegerQueue();

            queue.AddLast(1);
            queue.AddLast(2);
            queue.AddLast(3);

            Console.WriteLine("Kolejka: " + queue.ToString());

            int firstElement = queue.GetFirst();
            Console.WriteLine("Pobrany element z początku kolejki: " + firstElement);

            Console.WriteLine("Kolejka po pobraniu: " + queue.ToString());
        }
    }
}
