using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BInaryTree
{
    public class BinaryTree<T> where T : IComparable
    {
        //Şimdi recursive bir çağrı yapalım
        public List<Node<T>> list { get; private set; }
        public BinaryTree()
        {
            list = new List<Node<T>>();
        }
        public List<Node<T>> InOrder(Node<T> root)
        {
            if (!(root == null))//root ifadesi null olmadığı sürece dolaşmamız gerekmektedir
            {
                InOrder(root.Left);
                list.Add(root);
                InOrder(root.Right);
            }
            return list;
        }
        public List<Node<T>> InOrderNonRecursiveTraversal(Node<T> root)
        {
            var list = new List<Node<T>>();
            var S = new Stack<Node<T>>();
            Node<T> currentNode = root;
            bool done = false;
            while (!done)
            {
                if (currentNode != null)
                {
                    S.Push(currentNode);
                    currentNode = currentNode.Left;
                }
                else
                {
                    if (S.Count == 0)
                    {

                        done = true;
                    }
                    else
                    {
                        currentNode = S.Pop();
                        list.Add(currentNode);
                        currentNode = currentNode.Right;
                    }
                }
            }
            return list;
        }
        public List<Node<T>> PreOrder(Node<T> root)
        {
            if (!(root == null))
            {
                list.Add(root);
                PreOrder(root.Left);
                PreOrder(root.Right);
            }
            return list;
        }
        public List<Node<T>> PreOrderNonRecursiveTraversal(Node<T> root)
        {
            var list = new List<Node<T>>();//liste yapımızı oluşturduk.
            var s = new Stack<Node<T>>();//stack(yığın) yapımızı oluşturduk.
            if (root == null)
            {
                throw new ArgumentNullException("root");
            }
            s.Push(root);
            while (!(s.Count == 0))
            {
                var temp = s.Pop();
                list.Add(temp);
                if (temp.Right != null)
                {
                    s.Push(temp.Right);

                }
                if (temp.Left != null)
                {
                    s.Push(temp.Left);
                }
            }
            return list;
        }
        public List<Node<T>> PostOrder(Node<T> root)
        {
            if (!(root == null))
            {

                PostOrder(root.Left);
                PostOrder(root.Right);
                list.Add(root);

            }
            return list;
        }

        public List<Node<T>> LevelOrderNonRecursiveTraversal(Node<T> root)
        {
            var list = new List<Node<T>>();
            var Q = new Queue<Node<T>>();
            Q.Enqueue(root);//parametre olarak aldığım root ifadesini Enqueue ile " kuyruğuna eklmesini yapıyorum.
            while (Q.Count > 0)
            {
                var temp = Q.Dequeue();//Koşul devam ettiği sürece kuyruktan bir elemanı aıp temp değişkenine atıyorum.
                list.Add(temp);
                if (temp.Left != null)
                {
                    Q.Enqueue(temp.Left);
                }

                if (temp.Right != null)
                {
                    Q.Enqueue(temp.Right);

                }
            }
            return list;
        }

        public Node<T> FindMax(Node<T> root)//Binary tree'de maksimum kökü bulalım.
        {
            var current = root;
            while (!(current.Right == null))//current null'dan farklı bir duruma sahip ise döngüden çıkmamız beklenecektir.
            {
                current = current.Right;

            }
            return current;
        }

        public Node<T> FindMin(Node<T> root)
        {
            var current = root;
            while (!(current.Left==null))
            {
                current=current.Left;
            }
            return current;
        }
       
        //Binary tree'de istenen değeri bulmaya yarayan metod yazmaktayız.Ve bu metod yine verilen düz diziyi sıralama işlemini yaparkenki
        // gibi kök'ten başlayıp büyüklük küçüklük ilişkisine göre,küçük ise sol'dan,büyük ise sağ taraftan ilerleme göstermektedir.
        public Node<T> Find(Node<T> root,T key)
        {
            //key aranan değerdir
            var current = root;
            while (key.CompareTo(current.Value)!=0)
            {
                if (key.CompareTo(current.Value)<0)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;

                }
                if (current == null)
                {
                    throw new Exception("Could not found!");
                }
            }
            return current;
        }
        public Node<T> Remove(Node<T> root,T key)
        {
            if (root == null)
            {
                return root;//throw new ArgumentNullException();
            }
            if (key.CompareTo(root.Value)<0)
            {
                root.Left = Remove(root.Left, key);
            }
            else if(key.CompareTo(root.Value) > 0)
            {
                root.Right=Remove(root.Right, key); 
            }
            else
            {
                //silme işlemini uygulayabiliriz.
                //tek çocuk yada çocuk yok ise.
                if (root.Left == null)
                {
                    return root.Right;
                }
                else if (root.Right == null)
                {
                    return root.Left;
                }
                //iki çocuk var ise
                root.Value = FindMax(root.Right).Value;
                root.Right= Remove(root.Right, key);
            }
            return root;

        }
        public static int MaxDepth(Node<T> root)
        {
            if (root==null)
            {
                return 0;
            }
            int LeftDepth=MaxDepth(root.Left);
            int RightDepth=MaxDepth(root.Right);
            return (LeftDepth > RightDepth) ?
                LeftDepth + 1:
                RightDepth + 1;

        }
        public Node<T> DeepestNode(Node<T> root)
        {
            Node<T> temp = null;
            if (root==null)
            {
                throw new Exception("Empty tree");
                var q = new Queue<Node<T>>();
                q.Enqueue(root);
                while (q.Count>0)
                {
                    temp = q.Dequeue();
                    if (temp.Left != null)
                    {
                        q.Enqueue(temp.Left);

                    }
                    if (temp.Right != null)
                    {
                        q.Enqueue(temp.Right);
                    }
                    
                }

            }
            return temp;
        }
       //Yaprakları saymak için kullanılır.
        public int NumberOfLeafs(Node<T> root)
        {
            int count = 0;
            if (root==null)
            {
                return count;
            }
            var q =new Queue<Node<T>>();
            q.Enqueue(root);
            while (q.Count>0)
            {

                var temp = q.Dequeue();
                if (temp.Left == null && temp.Right == null)
                    count++;
                if (temp.Left!=null)
                {
                    q.Enqueue(temp.Left);
                }
                if (temp.Right!=null)
                {
                    q.Enqueue(temp.Left);
                }

            }
            return count;
        }
        public void PrintPaths(Node<T> root)
        {
            var path = new T[256];//yolların organizasyonu için path şeklinde bir tanımlma yapacağız.
            PrintPaths(root,path, 0);
        
        }
        private void PrintArray(T[] path,int len)
        {
            for(int i = 0; i < len; i++)
            {
                Console.Write($"{path[i]}");
            }
            Console.WriteLine();
        }

    }

    }

