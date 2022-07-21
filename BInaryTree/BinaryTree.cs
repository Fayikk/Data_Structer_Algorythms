using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BInaryTree
{
    public class BinaryTree<T> where T:IComparable
    {
        //Şimdi recursive bir çağrı yapalım
        public List<Node<T>> list { get; private set; }
        public BinaryTree()
        {
            list= new List<Node<T>>();  
        }
        public List<Node<T>> InOrder(Node<T> root)
        {
            if (!(root==null))//root ifadesi null olmadığı sürece dolaşmamız gerekmektedir
            {
                InOrder(root.Left);
                list.Add(root);
                InOrder(root.Right);    
            }
            return list;
        }
        public List<Node<T>> InOrderNonRecursiveTraversal(Node<T> root)
        {
            var list=new List<Node<T>>();
            var S = new Stack<Node<T>>();
            Node<T> currentNode = root;
            bool done = false;
            while (!done)
            {
                if (currentNode!=null)
                {
                    S.Push(currentNode);
                    currentNode = currentNode.Left;
                }
                else
                {
                    if (S.Count==0)
                    {

                        done = true;
                    }
                    else
                    {
                        currentNode = S.Pop();
                        list.Add(currentNode);
                        currentNode=currentNode.Right;
                    }
                }
            }
            return list;
        }
        public List<Node<T>> PreOrder(Node<T> root)
        {
            if (!(root==null))
            {
                list.Add(root);
                PreOrder(root.Left);
                PreOrder(root.Right);
            }
            return list;
        }
        public List<Node<T>> PreOrderNonRecursiveTraversal(Node<T> root)
        {
            var list= new List<Node<T>>();//liste yapımızı oluşturduk.
            var s = new Stack<Node<T>>();//stack(yığın) yapımızı oluşturduk.
            if (root==null)
            {
                throw new ArgumentNullException("root");
            }
            s.Push(root);
            while (!(s.Count==0))
            {
                var temp = s.Pop();
                list.Add(temp);
                if (temp.Right!=null)
                {
                    s.Push(temp.Right);

                }
                if (temp.Left!=null)
                {
                    s.Push(temp.Left);
                }
            }
            return list;
        }
        public List<Node<T>> PostOrder(Node<T> root)
        {
            if (!(root==null))
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
            while (Q.Count>0)
            {
                var temp=Q.Dequeue();//Koşul devam ettiği sürece kuyruktan bir elemanı aıp temp değişkenine atıyorum.
                list.Add(temp);
                if (temp.Left != null)
                {
                    Q.Enqueue(temp.Left);
                }
                
                if (temp.Right!=null)
                {
                    Q.Enqueue(temp.Right);

                }
            }
            return list;
        }
    }
}
