using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SinglyLinkedLists
{
    public class SinglyLinkedList
    {
        public SinglyLinkedListNode FirstNode { get; set; }

        public override string ToString()
        {
            string str;
            if (FirstNode == null)
            {
                return "{ }";
            }
            else if (FirstNode.Next == null)
            {
                str = "{ \"" + FirstNode + "\" }";
                return str;
            }
            {
                var strBuilder = new System.Text.StringBuilder();
                strBuilder.Append("{ \"" + FirstNode + "\", ");
                strBuilder.Append("\"" + FirstNode.Next + "\", ");
                strBuilder.Append("\"" + FirstNode.Next.Next + "\" }");
                return strBuilder.ToString();
            }
        }

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

            //node = LastNode(); - does not currently work
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
                FirstNode.Next.Next.Next = node;
            }
        }

        // NOTE: There is more than one way to accomplish this.  One is O(n).  The other is O(1).
        public int Count()
        {
            SinglyLinkedListNode currentnode = FirstNode;
            int i = 0;
            while (currentnode != null)
            {
                currentnode = currentnode.Next;
                i++;
            }
            return i;
        }

        public string ElementAt(int index)
        {
            int i = 0;
            SinglyLinkedListNode currentnode = FirstNode;

            if (FirstNode == null)
            {
                throw new ArgumentOutOfRangeException();
            } else if (currentnode != null)
            {
                while (i < index)
                {
                    currentnode = currentnode.Next;
                    i++;
                }
                return currentnode.Value;
            } else
            {
                return null;
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

        private SinglyLinkedListNode LastNode()
        {
            SinglyLinkedListNode lastnode;
            SinglyLinkedListNode currentnode = FirstNode;

            if (FirstNode == null)
            {
                return null;
            } 
            else
            {
                while (!currentnode.IsLast())
                {
                    currentnode = currentnode.Next;
                }
                lastnode = currentnode;
                return lastnode;
            }
        }

        public string Last()
        {
            if (FirstNode == null)
            {
                return null;
            }
            else {
                return LastNode().Value;
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
            if (FirstNode == null)
            {
                string[] empty = { };
                return empty;
            }
            else 
            {
                string[] listArray = new string[this.Count()];
                for (int i = 0; i < this.Count(); i++)
                {
                    listArray[i] = ElementAt(i);
                }
                return listArray;
            }
        }
    }
}
