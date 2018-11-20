using System;
using System.Collections;
using System.Collections.Generic;
using DoublyLinkedListImplementation.DoublyLinkedListNode;

namespace DoublyLinkedListImplementation.LinkedListClasses
{
    //Implementation of DoublyLinkedList
    //implements generic ICollection and IEnumerable interface
    public class DoublyLinkedList<T> : ICollection<T>, IEnumerable<T>
    {
        //node to keep track of head of the list
        private DoublyLinkedListNode<T> head;
        //node to keep track of tail of the list
        private DoublyLinkedListNode<T> tail;
        //size of the list
        private int size;
        //Constructor
        public DoublyLinkedList()
        {
            size = 0;
        }

        //return size of the list
        public int getSize() { return size; }

        //Overridden method from ICollection interface to add a value at the end of the list
        public void Add(T item)
        {
            if (item != null)
            {
                DoublyLinkedListNode<T> temp = new DoublyLinkedListNode<T>(item, null, tail);
                if (tail != null)
                {
                    tail.Next = temp;
                }
                tail = temp;
                if (head == null)
                {
                    head = temp;
                }
                size++;
            }
            else
            {
                Console.WriteLine("Item cannot be null!");
            }
        }

        //Overridden method from ICollection interface to remove a value from the list, if multiple nodes with same value
        //present in the list then remove the first occuerence
        public bool Remove(T item)
        {
            if (item != null)
            {
                DoublyLinkedListNode<T> current = head;
                if (current != null)
                {
                    if (current.Next == null && current.Value.Equals(item))
                    {
                        head = null;
                        Console.WriteLine("Item removed from list!");
                        return true;
                    }
                    while (!current.Value.Equals(item) && current.Next != null)
                    {
                        current = current.Next;
                    }
                    if (current.Value.Equals(item) && current.Next != null && current.Previous != null)
                    {
                        current.Previous.Next = current.Next;
                        current.Next.Previous = current.Previous;
                        size--;
                        Console.WriteLine("Item removed from list!");
                        return true;
                    }
                    else if (current.Value.Equals(item) && current.Next == null)
                    {
                        current.Previous.Next = current.Next;
                        size--;
                        Console.WriteLine("Item removed from list!");
                        return true;
                    }
                    else if (current.Value.Equals(item) && current.Previous == null)
                    {
                        head = current.Next;
                        size--;
                        Console.WriteLine("Item removed from list!");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Item not found in the list!");
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("List is empty!");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Item cannot be null!");
                return false;
            }
        }

        //method to iterate the list with foreach statement
        public void iterate()
        {
            foreach (T it in this)
            {
                Console.WriteLine(it);
            }
        }

        //overridden method from IEnumerable interface to provide the Enumerator for the list to iterate
        public IEnumerator<T> GetEnumerator()
        {
            for (DoublyLinkedListNode<T> it = head; it != null;)
            {
                DoublyLinkedListNode<T> next = it.Next;
                yield return it.Value;
                it = next;
            }
        }

        //The following methods does not have an implementation, as they are not in the scope of the assignment but their 
        //definition is necessary as part of implementing the interface
        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
