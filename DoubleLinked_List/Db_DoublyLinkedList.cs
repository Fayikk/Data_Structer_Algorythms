using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinked_List
{
    public class Db_DoublyLinkedList<T>
    {
        public DoublyLinkedList<T> Prev { get; set; }
        public DoublyLinkedList<T> Next { get; set; }

        public Db_DoublyLinkedList(T value)
        {
            Value = value;
        }
        public override string ToString() => Value.ToString();   
      }
}
