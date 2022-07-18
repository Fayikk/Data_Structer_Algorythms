using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedListt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Linked list yapısı c#'ta koleksiyonlar ile gelen bir yapdır
            var linkedlist = new SinglyLinkedList<int>();
            linkedlist.AddFirst(1);
            linkedlist.AddFirst(2);
            linkedlist.AddFirst(3);
            //3 2 1
           linkedlist.AddLast(4);
           linkedlist.AddLast(5);
           linkedlist.AddLast(6);
            //3 2 1 4 5 6

            linkedlist.AddAfter(linkedlist.Head.Next, 1998);
            linkedlist.AddAfter(linkedlist.Head.Next.Next.Next, 69);//1 ile 4 arasına ekleme yapılacaktır.
            //3 2 1998 1 4 5 6
            var list = new LinkedList<int>();
            list.AddFirst(1);
            list.AddFirst(2);   
            list.AddFirst(3);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

           
        
        }
    }
}
