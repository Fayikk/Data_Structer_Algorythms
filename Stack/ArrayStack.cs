using System;
using System.Collections.Generic;

namespace Stack
{
    internal class ArrayStack<T> : IStack<T>
    {
        public int Count { get; private set; }

        private readonly List<T> list = new List<T>();

        public T Peek()
        {
            if (Count == 0)
            {
                throw new Exception("Empty Stack");
                
            }
            return list[list.Count - 1];
        }

        public T pop()
        {
            if (Count == 0)
            {
                //return default(T);//bu bir integer ise 0 döndürür.Datetime ise default tarihde ğerini dndürür
                throw new Exception("Empty Stack");
            }
            var temp = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            Count--;
            return temp;
        }
        public void Push(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }
            list.Add(value);
            Count++;
        }

        

        
    }
}