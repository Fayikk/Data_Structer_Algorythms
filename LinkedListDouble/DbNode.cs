using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDouble
{
    public class DoublyLinkedListNode<T>
    {
        public DoublyLinkedListNode<T> prev { get; set; }
        public DoublyLinkedListNode<T> Next { get; set; }
        public object Value { get; private set; }

        public DoublyLinkedListNode(T value)
        {
            Value = value;

        }
        public override string ToString() => Value.ToString();
        
    }
}
