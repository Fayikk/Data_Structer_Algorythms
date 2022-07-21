using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_S_TREE
{
    public class Node<T>
    {
        public T Value { get; set; }

        public Node(T value)
        {
            Value = value;
        }

        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }
        public Node()
        {
                
        }
        public override string ToString()
        {
            return $"{Value}";
        }

    }
}
