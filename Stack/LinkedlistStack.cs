using System;
using System.Collections.Generic;

namespace Stack
{
    internal class ArrayStackStack<T> : IStack<T>
    {
       

        public int Count { get; private set; }

        private readonly LinkedListStack<T> list = new List<T>();

        public T Peek()
        {
            throw new System.NotImplementedException();
        }

        public T pop()
        {
            throw new System.NotImplementedException();
        }

        public void Push(T value)
        {
            list.Add(value);
            Count++;
        }
    }
}