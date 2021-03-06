﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

        public class Iterator
        {
            public string GetCurrent()
            {
                return current.element;
            }

            public bool MoveNext()
            {
                current = current.next;
                return current != null;
                //                bool noNextElement = current == null;
                //                //if (current == null)
                //                if (noNextElement)
                //                {
                //                    return false;
                //                }
                //                else
                //                {
                //                    return true;
                //                }
            }

            public Iterator(LinkedList list)
            {
                current = list.head;
            }

            private Node current;
        }

        public Iterator GetIterator()
        {
            return new Iterator(this);
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

        public void WriteList()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.element);
                current = current.next;
            }
        }

        public int GetLength() // TODO
        {
            Node current = head;
            if (head == null)
            {
                return 0;
            }
            int lengthCounter = 1;
            while (current.next != null)
            {
                current = current.next;
                lengthCounter++; // same as lenghtCounter = lenghtCounter +1;
            }
            return lengthCounter;
        }
        public void RemoveElement(int elementToRemove)
        {
            if (elementToRemove == 0)
            {
                head = head.next;
                return;
            }
            Node current = head;
            int currentElementNumber = 0;
            while (current != null)
            {
                if (currentElementNumber == elementToRemove - 1)
                {
                    current.next = current.next.next;
                }
                current = current.next;
                currentElementNumber++;
            }
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
    }
}
