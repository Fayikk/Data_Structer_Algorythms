using System;
using System.Collections.Generic;

namespace BinaryHeap
{
    public class MinHeap<T>:BHeap<T>,IEnumerable<T>//kalıtım ile BHeap sınıfını alıyoruz.Gerekli metodları kullanabilmek için.
    where T : IComparable    
    {

        public MinHeap():base()
        {

        }
        public MinHeap(int _size):base( _size)
        {

        }
        public MinHeap(IEnumerable<T> collection): base(collection)
        {

        }
        //Heapifydown aşağı doğru salınma işlemi.Kök'ü siliyoruz.
        protected override void HeapifyDown()
        {
            int index = 0;
            while (HasLeftChild(index)//heapproperty uymak için sol çocuklar kontrol edilecektir.
            {
                var smallerIndex = GetLeftChildIndex(index);
                if (HasRightChild(index)&& GetRightChild(index).CompareTo(GetLeftChild(index))<0 )
                {
                    smallerIndex = GetRightChildIndex(index);
                }
                if (Array[smallerIndex].CompareTo(Array[index]) >= 0)
                {
                    break;
                }
                Swap(smallerIndex, index);
                index=smallerIndex;
            }
        }
        protected override void HeapifyUp()
        {
            throw new NotImplementedException();
        }
    }


}


