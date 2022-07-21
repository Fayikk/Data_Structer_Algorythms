using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BInaryTree;

namespace B_S_TREE
{
    public class BST<T> : IEnumerable<T>//foreach yapsını destekleyen ve elemanlar üzerinde dolaşmamıza izin veren bir yapıdır.
        where T:IComparable//ifadelerin karşılaştırılabilir olması gerekmektedir.
    {
        public BST(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Add(item);
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public Node<T> Root { get; set; }
        
        public void Add (T value)
        {
            if (value==null)
            {
                throw new ArgumentNullException("value");
            }
            var newNode=new Node<T>(value);
            if (Root==null)
            {
                Root = newNode;
                return;
            }
            else
            {
                var current = Root;
                Node<T> parent;
                while (true)
                {
                    parent = current;
                    //Sol alt ağaç
                    if (value.CompareTo(current.Value)<0)
                    {
                        current = current.Left;
                        if (current==null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }
                    //sağ alt ağaç
                    else
                    {
                        current=current.Right;
                        if (current==null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }

                }
            }
        }


    }
}
