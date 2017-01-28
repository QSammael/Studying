using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class LinkedList
    {
        class Node
        {
            public string element;
            public Node next;
        }
        public void Add(string elementToInsert)
        {
            if (head == null)
            {
                head = new Node();
                head.element = elementToInsert;
                return;
            }
            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            Node last = new Node();
            last.element = elementToInsert;
            current.next = last;
        }
        public string GetElement(int elementNumber)// TODO
        {
            Node current = head;
            int currentIndex = 0;
            while (currentIndex < elementNumber)
            {
                current = current.next;
                currentIndex = currentIndex + 1;
            }
            return current.element;
        }

        public int GetLength() // TODO
        {
            Node current = head;
            int lengthCounter = 0;
            while (current != null)
            {
                current = current.next;
                lengthCounter++; // same as lenghtCounter = lenghtCounter +1;
            }
            return lengthCounter;
        }

        void InsertFirst(string elementToInsert)
        {
            Node newHead = new Node();
            newHead.element = elementToInsert;
            newHead.next = head;
            head = newHead;
        }

        void RemoveFirst()
        {
            head = head.next;
        }
        private Node head;
        public void RemoveElement(int elementNumber)
        {
            Node current = head;
            int elementToRemove = 1;
            while (current != null)
            {
                current = current.next;
                elementToRemove++;
                if (elementToRemove == elementNumber)
                {
                    current = current.next;
                }
            }
        }
    }
}
