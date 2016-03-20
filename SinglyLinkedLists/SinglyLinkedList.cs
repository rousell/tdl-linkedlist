using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SinglyLinkedLists
{
    public class SinglyLinkedList
    {
        public SinglyLinkedListNode FirstNode { get; set; }

        public SinglyLinkedList()
        {
            // NOTE: This constructor isn't necessary, once you've implemented the constructor below.
        }

        // READ: http://msdn.microsoft.com/en-us/library/aa691335(v=vs.71).aspx
        public SinglyLinkedList(params object[] values)
        {
            throw new NotImplementedException();
        }

        // READ: http://msdn.microsoft.com/en-us/library/6x16t2tx.aspx
        public string this[int i]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public void AddAfter(string existingValue, string value)
        {
            throw new NotImplementedException();
        }

        public void AddFirst(string value)
        {
            SinglyLinkedListNode node = new SinglyLinkedListNode(value);
            FirstNode = node;
        }

        public void AddLast(string value)
        {
            SinglyLinkedListNode node = new SinglyLinkedListNode(value);


            if (FirstNode == null)
            {
                FirstNode = node;
            } else if (FirstNode.Next == null)
            {
                FirstNode.Next = node;
            } else if (FirstNode.Next.Next == null)
            {
                FirstNode.Next.Next = node;
            } else
            {
                
            }
        }

        // NOTE: There is more than one way to accomplish this.  One is O(n).  The other is O(1).
        public int Count()
        {
            throw new NotImplementedException();
        }

        public string ElementAt(int index)
        {
            int i = 0;
            SinglyLinkedListNode currentnode = FirstNode;

            if (FirstNode == null)
            {
                throw new ArgumentOutOfRangeException();
            } else
            {
                while (i < index)
                {
                    currentnode = currentnode.Next;
                    i++;
                }
                return currentnode.Value;
            }
            
        }

        public string First()
        {
            return FirstNode?.ToString();
        }

        public int IndexOf(string value)
        {
            throw new NotImplementedException();
        }

        public bool IsSorted()
        {
            throw new NotImplementedException();
        }

        // HINT 1: You can extract this functionality (finding the last item in the list) from a method you've already written!
        // HINT 2: I suggest writing a private helper method LastNode()
        // HINT 3: If you highlight code and right click, you can use the refactor menu to extract a method for you...
        public string Last()
        {
            if (FirstNode == null)
            {
                return null;
            } 
            else if (FirstNode.Next == null)
            {
                return FirstNode.Value;
            }
            else if (FirstNode.Next.Next == null)
            {
                return FirstNode.Next.Value;
            }
            else
            {
                return "string";
            }
        }

        public void Remove(string value)
        {
            throw new NotImplementedException();
        }

        public void Sort()
        {
            throw new NotImplementedException();
        }

        public string[] ToArray()
        {
            throw new NotImplementedException();
        }
    }
}
