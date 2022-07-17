using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Array
{
    public class Array<T> : IEnumerable<T>,ICloneable//Unboxing ile uğraşmamak ve type-safe'i sağlamak için generic ifadeler ile çalışyoruz. 
    {
        private T[] InnerList;
        public int Count { get; private set; }

        internal void Remove(int v)
        {
            throw new NotImplementedException();
        }
        public Array(params T[] initial)
        {
            InnerList = new T[initial.Length];
            Count = 0;
            foreach (var item in initial)
            {
                Add(item);
            }

        }
        public int Capacity => InnerList.Length;
        public Array()
        {
            InnerList = new T[2];//array 2 haneli    
            Count = 0;
        }

        public void Add(T item)
        {
            if (InnerList.Length==Count)
            {
                DoubleArray();
            }
            InnerList[Count] = item;
            Count++;
        }

        private void DoubleArray()//dizizlerde ekleme işlemlerine bağlı olarak dizi boyutunu katmlama işlemleri 
        {
            //Innerlist normal koşuularda bir array ve bunun otomatik olarak dinamikte boş alan oluştuma özelliği yoktur.
            //Dolayısıyla aşağıda birtakım işlemler yapılarak ınnerlist yüklenecek alan bulamadığı zamanlarda
            //kendi boyutunun 2katı olan örtülü bir değişken olan temp'e atanmaktadır.
            //aşağıda eşitleme işlemleriden sonra Innerlist manuel olarak dinamik bir hale dönüşmüş sayılabilir.
            var temp=new T[InnerList.Length*2];
            System.Array.Copy(InnerList, temp, InnerList.Length);
            InnerList = temp;
        }
        public T Remove()//Dizilerde kaldırma işlemi 
        {
            if (Count == 0)
                throw new Exception("There is no more item to be removed from the array");
            
            if (InnerList.Length/4==Count)
            {
                HalfArray();
            }
            var temp = InnerList[Count - 1];
            Count--;
            return temp;
        }

        private void HalfArray()
        {
            if (InnerList.Length>2)
            {
                var temp = new T[InnerList.Length / 2];
                System.Array.Copy(InnerList, temp, temp.Length);
                InnerList = temp;
            }
        }

        public object Clone()//İLGİLİ NESNENİN BİR KOPYASINI OLUŞTURUR.
        {
            return this.MemberwiseClone();//ilgili ögenin tüm özelliklerini yeni ögeye geçirme işlemleri için kullanılırlar.
        }

        public IEnumerator<T> GetEnumerator()
        {
            return InnerList.Take(Count).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    //IEnumerable<T> sayesinde koleksiyonu numaralamdırabilme yetenği kazandırmış oluyoruz.
    //VE aynı zaman bu interaface sayesinde LINQ DEDİĞİMİZ DİLE ENTEGRE SORGULARI kullanabiliyoruz.
    //Şuanda koleksiyonumuza numaralndırma yetenği kazandırmış olduk.

        

    }

