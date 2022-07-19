using System;
using System.Collections.Generic;

namespace LinkedListDouble
{
    public class Program
    {
        static void Main(string[] args)
        {
            var list = new DoublyLinkedList<char>(new List <char>() { 'a', 'b', 'c' ,'d','e','f'});

            //Console.WriteLine($"kaldırılan ifadedir{list.RemoveFirst()}");
            //şu ifadenin tamamı bir char ifadesine karşılık gelir.
            //RemoveFirst metodu ile ilk ifademizi silmiş olacağız.
            Console.WriteLine($"Kaldırılan ifade: {list.RemoveLast()}");//linked listin sonundan eleman kaldıracktır.
            
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        
        }

        private static void DoublyLinkedLİst()
        {
            var list = new DoublyLinkedList<int>();
            list.FirstAdd(1);
            list.FirstAdd(12);
            list.FirstAdd(13);
            //13  12  1


            list.AddLast(44);
            list.AddLast(55);


            list.AddAfter(list.Head.Next, new DoublyLinkedListNode<int>(16));
            //13  16  12  1
            list.AddBefore(list.Head.Next.Next.prev, new DoublyLinkedListNode<int>(66));
            //13  16 66 12  1


            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
 