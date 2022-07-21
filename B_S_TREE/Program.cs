using BInaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_S_TREE
{
    public class Program
    {
        static void Main(string[] args)
        {
            var BST = new BST<int>(new int[] { 23, 16, 45, 3, 22, 37, 99 });

            //new BinaryTree<int>().InOrder(BST.Root).ForEach(node =>Console.Write(node+ " "));//InOrder sıralam işlemi gösterilmiştir.
            //new BinaryTree<int>().InOrderNonRecursiveTraversal(BST.Root).ForEach(node => Console.Write(node + " "));//non recursive ifade ile (iteratif çalışan) InOrder ifadeyi yazdırma işlemini gerçekleştirdik.

            //new BinaryTree<int>().PreOrder(BST.Root).ForEach(node =>Console.Write(node+ " "));//Yukarıda girilen elemanların ikili ağaç sisteminde preorder sıralama process'i gösterilmiştir.
            //new BinaryTree<int>().PreOrder(BST.Root).ForEach(node => Console.Write(node + " "));//Yukarıda girilen elemanların ikili ağaç sisteminde preorder sağ sıralama process'i gösterilmiştir.
            //new BinaryTree<int>().PreOrderNonRecursiveTraversal(BST.Root).ForEach(node => Console.Write(node + " "));

            //Console.WriteLine();
            //new BinaryTree<int>().PostOrder(BST.Root).ForEach(node => Console.Write(node + " "));//PostOrder ikili arama mantığıyla sıralama işlemini gerçekleştirdik.
            //Console.WriteLine();
            //new BinaryTree<int>().LevelOrderNonRecursiveTraversal(BST.Root).ForEach(node => Console.Write(node + " "));



            Console.ReadKey();
        }
    }
}
