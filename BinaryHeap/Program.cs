using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryHeap
{
    public class Program
    {
        static void Main(string[] args)
        {
            var heap = new MaxHeap<int>(new int[] {54,45,36,27,29,18,21,11,99});

            
            foreach (var item in heap)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("************");
            Console.WriteLine("Heap'ten kaldırılan ifade->" + heap.DeleteMinMax());

            foreach (var item in heap)
            {
                Console.WriteLine(item);
            }



            //Console.WriteLine(heap.DeleteMinMax() + "  has been removed.");
            //    Console.WriteLine();

            //    foreach (var item in heap)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    Console.ReadKey();
            //
        }
    }
}
