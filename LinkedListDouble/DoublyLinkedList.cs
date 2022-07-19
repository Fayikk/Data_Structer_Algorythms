using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDouble
{
    public class DoublyLinkedList<T>:IEnumerable
    {
        private T value;
        private T temp1;

        public DoublyLinkedList()
        {
        }

        public DoublyLinkedList(T value)
        {
            this.value = value;
        }

        //public DoublyLinkedList()
        //{

        //}
        public DoublyLinkedList(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                AddLast(item);

            }
        }
        public DoublyLinkedListNode<T> Head { get; set; }
        public DoublyLinkedListNode<T> Tail { get; set; }
        private bool isHeadNull => Head == null;
        public bool IsTailNull => Tail == null; 
        public T Current => throw new NotImplementedException();

        

        public void FirstAdd(T value)
        {
            var newNode=new DoublyLinkedListNode<T>(value);
            if (Head!=null)
            {
                Head.prev = newNode;
            }
            newNode.Next = Head;
            newNode.prev = null;
            Head = newNode;//head ifademiz newNode'a eşittir diyebiliriz.

            if (Tail==null)
            {
                Tail = Head;
            }
            
        
        }  
        public void AddLast(T value)
        {
            if (Tail == null)
            {
                FirstAdd(value);
                return;
            }

            var newNode=new DoublyLinkedListNode<T>(value);
            Tail.Next = newNode;
            newNode.Next = null;
            newNode.prev = Tail;
            Tail = newNode;
            return;
        }
        public void AddAfter(DoublyLinkedListNode<T> refNode,
           DoublyLinkedListNode<T> newNode )
        {
            if (refNode == null)
            {
                throw new ArgumentException();
            }

            if (refNode==Head && refNode==Tail)
            {
                refNode.Next = newNode;
                refNode.prev = null;
                newNode.prev = refNode;
                newNode.Next = null;
                Head = refNode;
                Tail = newNode;
                return;
            }

            if (refNode != Tail)
            {
                newNode.prev = refNode;
                newNode.Next = refNode.Next;
                refNode.Next.prev = newNode;
                refNode.Next = newNode;
            }
            else
            {
                newNode.prev = refNode;
                newNode.Next = null;
                refNode.Next = newNode;
                Tail = newNode;
            }

        }

        public void AddBefore(DoublyLinkedListNode<T> refNode,DoublyLinkedListNode<T> newNode)
        {
            if (refNode==null)
            {
                throw new ArgumentException();
            }
            if(refNode==Head && refNode == Tail)
            {
                refNode.Next = null;
                refNode.prev = newNode;
                newNode.Next = refNode;
                newNode.prev = null;
                Head = newNode;
                Tail = refNode;
                return;
            }
            if (refNode != Head)
            {
                newNode.Next = refNode;
                newNode.prev = refNode.prev;
                refNode.prev.Next = newNode;
                refNode.prev= newNode;

            }
            else
            {
                newNode.prev = null;
                newNode.Next = refNode;
                refNode.prev = newNode;
                Head = newNode;
            }
        }

        private List<DoublyLinkedListNode<T>> GetAllNodes()
        {
            var list = new List<DoublyLinkedListNode<T>>();
            var current = Head;
            while (current != null)
            {
                list.Add(current);

                current = current.Next;
            }
            return list;

        }

        public IEnumerator GetEnumerator()
        {
            return GetAllNodes().GetEnumerator();
        }
        public T RemoveFirst()
        {
            if (isHeadNull)
            {
                throw new Exception("");
            }
            var temp = Head.Value;
            if (Head == Tail)
            {
                Head=null;
                Tail = null;
            }
            else
            {
                Head=Head.Next;
                Head.prev = null;

            }
            return (T)temp;
        }
        public T RemoveLast()
        {
            if (IsTailNull)
            {
                //eğer kuyruk ifadesi boş ise.Silinecek birşey yok demektir
                throw new Exception("Empty list.");

                var temp1=Tail.Value;
                if (Tail==Head)
                {
                    Head = null;
                    Tail=null;
                }
                else
                {
                    Tail.prev.Next = null;
                    Tail = Tail.prev;

                }

            }
            return (T)temp1;

        }



    }
}
