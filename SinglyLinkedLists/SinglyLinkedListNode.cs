using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Stretch Goals: Using Generics, which would include implementing GetType() http://msdn.microsoft.com/en-us/library/system.object.gettype(v=vs.110).aspx
namespace SinglyLinkedLists
{
    public class SinglyLinkedListNode : IComparable
    {
        // Used by the visualizer.  Do not change.
        public static List<SinglyLinkedListNode> allNodes = new List<SinglyLinkedListNode>();

        // READ: http://msdn.microsoft.com/en-us/library/aa287786(v=vs.71).aspx
        private SinglyLinkedListNode next;
        public SinglyLinkedListNode Next
        {
            get { return this.next; }
            set {
                if (value == this)
                {
                    throw new ArgumentException();
                }


                this.next = value;
                    // value keyword refers to anything on the 
                    // right side of the sign operator, '='
                    
                    }
        }

        private string value; /*Access using "this.value"*/
        public string Value // get method
        {
            get { return value; }
        }

        public static bool operator <(SinglyLinkedListNode node1, SinglyLinkedListNode node2)
        {
            // This implementation is provided for your convenience.
            return node1.CompareTo(node2) < 0;
        }

        public static bool operator >(SinglyLinkedListNode node1, SinglyLinkedListNode node2)
        {
            // This implementation is provided for your convenience.
            return node1.CompareTo(node2) > 0;
        }

        public SinglyLinkedListNode(string value)
        {
            this.value = value; 
            // this is a private data member, not setting the property

            // Used by the visualizer:
            allNodes.Add(this);
        }

        public override string ToString()
        {
            return this.value;
        }

        public override bool Equals(object obj)
        {
            SinglyLinkedListNode temp = obj as SinglyLinkedListNode;
            if (temp == null)
            {
                return false;
            }
            else if (this.value == temp.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // READ: http://msdn.microsoft.com/en-us/library/system.icomparable.compareto.aspx
        public int CompareTo(Object obj)
        {
            if (obj.ToString()[0] > this.value[0])
            {
                return -1;
            } else if (obj.ToString()[0] < this.value[0])
            {
                return 1;
            } else
            {
                return 0;
            }
        }

        public bool IsLast()
        {
            if (this.next == null)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
