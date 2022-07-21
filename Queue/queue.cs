using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class queue<T>
    {

    }
    public interface IQueue<T>
    {
        int Count { get; }
        void Enqueue(T value);
        T DeQueue();
        T Peek();

    }
    public enum QueueType
    {
        Array=0,        //List<T> verinin boyutuna bağlı
        LinkedList=1,   //

    }
}
