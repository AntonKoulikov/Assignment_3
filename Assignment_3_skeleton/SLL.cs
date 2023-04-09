// Authors: Ryan Back, Anton Koulikov, Abubaker Essadi
// Date: April 9, 2023
// Program description: SAIT Software Development Diploma, CPRG-211-A

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_skeleton
{
    public class SLL : LinkedListADT
    {
        //Fields 
        private Node head;
        private int size;
        private Node tail;

        //Methods implemeneted from interface LinkedListADT 

        //Adds object to the end of the list
        public void Append(Object data)
        {
            Node new_Node = new Node();
            new_Node.Data = data;
            new_Node.Next = null;

            if (head == null)
            {
                head = new_Node;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new_Node;
            }
            size++;
        }

        //Clears the list
        public void Clear()
        {
            head = null;
            tail = null;
            size = 0;
        }

        //Goes through elements to check one contains the desired data.
        public bool Contains(Object data)
        {
            Node currentNode = head;

            while (currentNode != null)
            {
                if (currentNode.Data.Equals(data))
                {
                    return true;
                }

                currentNode = currentNode.Next;
            }

            return false;
        }

        //Removes an element at a given index from the list reducing the size by 1
        public void Delete(int index)
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException("Index cannot be negative");
            }

            if (head == null)
            {
                throw new IndexOutOfRangeException("List is empty");
            }

            if (index == 0)
            {
                head = head.Next;
                return;
            }

            Node currentNode = head;
            int i = 0;

            while (i < index - 1)
            {
                if (currentNode.Next == null)
                {
                    throw new IndexOutOfBoundsException("Index is out of bounds");
                }

                currentNode = currentNode.Next;
                i++;
            }

            currentNode.Next = currentNode.Next.Next;
        }

        //Gets the index of the first element containing the desired data
        public int IndexOf(Object data)
        {
            Node currentNode = head;
            int i = 0;

            while (currentNode != null)
            {
                if (currentNode.Data.Equals(data))
                {
                    return i;
                }

                currentNode = currentNode.Next;
                i++;
            }

            return -1;
        }

        //Adds a new element to the list containing given object data at a given index
        public void Insert(Object data, int index)
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException("Index cannot be negative");
            }

            Node new_Node = new Node(data);

            if (index == 0)
            {
                new_Node.Next = head;
                head = new_Node;
                return;
            }

            Node currentNode = head;
            int i = 0;

            while (i < index - 1 && currentNode != null)
            {
                currentNode = currentNode.Next;
                i++;
            }

            if (currentNode == null)
            {
                throw new IndexOutOfRangeException("Index is past the end of the list");
            }

            new_Node.Next = currentNode.Next;
            currentNode.Next = new_Node;
        }

        //Checks if the singly linked list is empty or not
        public bool IsEmpty()
        {
            return head == null;
        }

        //Adds object to the beginning of the list
        public void Prepend(Object data)
        {
            Node new_Node = new Node(data);

            new_Node.Next = head;
            head = new_Node;

            if (size == 0)
            {
                tail = head;
            }

            size++;
        }

        //Replaces the data in the element at the given index
        public void Replace(object data, int index)
        {
            if (index < 0 || index >= size)
            {
                throw new IndexOutOfRangeException();
            }
            Node current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            current.Data = data;
        }

        //Gets the data in the element at the given index
        public object Retrieve(int index)
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException("Index cannot be negative");
            }

            Node currentNode = head;
            int i = 0;

            while (currentNode != null && i < index)
            {
                currentNode = currentNode.Next;
                i++;
            }

            if (currentNode == null)
            {
                throw new IndexOutOfRangeException("Index is out of bounds");
            }

            return currentNode.Data;
        }

        //Gets the number of elements in the list or returns 0 if the list is empty
        public int Size() 
        {
            int count = 0;
            Node current = head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }
    }
}
