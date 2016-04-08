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
            SinglyLinkedListNode currentnode = FirstNode;
            var strBuilder = new System.Text.StringBuilder();
            if (FirstNode == null)
            {
                return "{ }";
            }
            else
            {
                int i = 0;
                while (currentnode != null)
                {
                    if (i == 0 && currentnode.Next == null)
                    {
                        strBuilder.Append("{ \"" + currentnode + "\" }");
                    }
                    else if (i == 0 && currentnode.Next != null)
                    {
                        strBuilder.Append("{ \"" + currentnode + "\"");
                    }
                    else if (currentnode.Next != null)
                    {
                        strBuilder.Append(", \"" + currentnode + "\"");
                    }
                    else if (currentnode.Next == null)
                    {
                        strBuilder.Append(", \"" + currentnode + "\" }");
                    }
                    currentnode = currentnode.Next;
                    i++;
                }
                return strBuilder.ToString();
            }
        }

        /*public SinglyLinkedList()
        {
            // NOTE: This constructor isn't necessary, once you've implemented the constructor below.
        }*/

        // READ: http://msdn.microsoft.com/en-us/library/aa691335(v=vs.71).aspx
        public SinglyLinkedList(params object[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                this.AddLast((string)values[i]);
            }
        }

        
        // READ: http://msdn.microsoft.com/en-us/library/6x16t2tx.aspx
        public string this[int i]
        {
            get { return this.ElementAt(i); }
            set
            {
                if (i == 0)
                {
                    AddFirst(value);
                } else
                {
                    UpdateValue(i, value);
                }
            }
        }

        public void UpdateValue (int index, string val)
        {
            SinglyLinkedListNode currentnode = FirstNode;
            SinglyLinkedListNode node = new SinglyLinkedListNode(val);

            for (int i = 1; i < index; i++)
            {
                currentnode = currentnode.Next;
            }
            currentnode.Next = node;
        }

        public void AddAfter(string existingValue, string value)
        {
            SinglyLinkedListNode node = new SinglyLinkedListNode(value);
            SinglyLinkedListNode existVal = new SinglyLinkedListNode(existingValue);
            SinglyLinkedListNode currentnode = FirstNode;
            if (FirstNode == null)
            {
                throw new ArgumentNullException();
            } else
            {
                while (currentnode.Value != existingValue)
                {
                    currentnode = currentnode.Next;

                    if (currentnode == null)
                    {
                        throw new ArgumentException();
                    }
                }
                if (currentnode.Value == existingValue)
                {
                    node.Next = currentnode.Next;
                    currentnode.Next = node;
                }
            }
        }

        public void AddFirst(string value)
        {
            SinglyLinkedListNode node = new SinglyLinkedListNode(value);

            if (FirstNode != null)
            {
                node.Next = FirstNode;
                FirstNode = node;
            } else
            {
                FirstNode = node;
            }
        }

        public void AddLast(string value)
        {
            SinglyLinkedListNode currentnode = FirstNode;
            SinglyLinkedListNode node = new SinglyLinkedListNode(value);

            //node = LastNode(); - does not currently work
            if (FirstNode == null)
            {
                FirstNode = node;
            }
            else
            {
                while (currentnode.Next != null)
                {
                    currentnode = currentnode.Next;
                }
                currentnode.Next = node;
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
            SinglyLinkedListNode currentnode = FirstNode;
            if (currentnode == null)
            {
                return -1;
            } 
            
            int i = 0;
            while (currentnode.Value != value)
            {
                currentnode = currentnode.Next;
                if (currentnode == null)
                {
                    return -1;
                }

                i++;
            }
            return i;
        }   

        public bool IsSorted()
        {
            return true;
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
            SinglyLinkedListNode currentnode = FirstNode;
            int deleteIndex = IndexOf(value);


            if (deleteIndex == -1)
            {
            } else if (deleteIndex == 0)
            {
                FirstNode = currentnode.Next;
            } else if (deleteIndex == 1)
            {
                currentnode.Next = currentnode.Next.Next;
            } 
            else
            {
                for (int i = 0; i < deleteIndex - 1; i++)
                {
                    currentnode = currentnode.Next;
                }
                if (Last() == value)
                {
                    currentnode.Next = null;
                }
                else
                {
                    currentnode.Next = currentnode.Next.Next.Next;
                    currentnode.Next.Next = null;
                }
            }


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
                int c = this.Count();
                string[] listArray = new string[c];
                for (int i = 0; i < c; i++)
                {
                    listArray[i] = ElementAt(i);
                }
                return listArray;
            }
        }
    }
}
