using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack2<T>
    {
        private readonly IStack<T> stack;
        public int Count => stack.Count;
        public Stack2(StackType type=StackType.Array)//eğer type'a herhangi bir değer ataması yapılmaz ise etürü default olarak StackType.Array olarak tanımlanacaktır. 
        {
            if(type == StackType.Array)
            {
                stack = new ArrayStack<T>();
            }
            //else
            //{
            //    stack = new LinkedListStack<T>();
            //}
        }
        public T Pop()
        {
            return stack.pop();
        }

        public T Peek()
        {
            return stack.Peek();
        }
        public void Push(T value)
        {
            stack.Push(value);
        }
    
    }

    public interface IStack<T>
    {
        int Count { get; }
        void Push(T value);
        T Peek();
        T pop();
    }

    public enum StackType
    {
        Array=0, //List<T>
        LinkedList=1 //SinglyLinkedList<T>
    }


}
