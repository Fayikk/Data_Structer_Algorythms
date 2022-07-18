using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedListt
{
    public class SinglyLinkedList<T>:IEnumerable<T>
    {
        public SinglyLinkedListNode<T> Head { get; set; }
        public void AddFirst(T value)//AddFirst metodu gerzaman listenin başına ekleme yapar.
        {
            var newNode = new SinglyLinkedListNode<T>(value);
            newNode.Next = Head;//newNode'u başlangıç düğümüne ekliyotuz.
            Head= newNode;//Referans düğümün yerini değiştiryoruz.

        }
        public void AddLast(T value)
        {
            var newNode = new SinglyLinkedListNode<T>(value);
            if (Head==null)//eğer bağlı liste içerisinde hiç eleman yok ise bu yapı kullanılacaktır
            {
                Head= newNode;
                return;
            }
            var current = Head;//Başlangıç noktamızı belli ediyoruz.Referansımız head'tir
            while (current.Next!=null)//NULL DEĞERİNE EŞİTLİK SAĞLANDIKTAN SONRA DÖNGÜDEN ÇIKMASI GEREKECEKTİR.
            {
                current = current.Next;
            }
            current.Next = newNode;

        }
        private bool isHeadNull=>Head==null;
        public void AddAfter(SinglyLinkedListNode<T> node, T value)
        {
            if (node == null)
            {
                throw new ArgumentNullException();
            }
            if(isHeadNull)
            {
                AddFirst(value);
                    return;
            }
            var newNode = new SinglyLinkedListNode<T>(value);
            var current = Head;
            while (current!=null)
            {
                if (current.Equals(node)){
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
                current=current.Next;
            }
            throw new ArgumentException("the reference node is not in this list");
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        
        public T RemoveFirst()
        {
            if (isHeadNull)
                throw new Exception("Underflow! Nothing to remove");
            var firstValue = Head.Value;
            Head = Head.Next;
            return firstValue;
        }
    
    
    }
}
