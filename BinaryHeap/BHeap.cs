using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryHeap
{
    public abstract class BHeap<T>:IEnumerable<T>
        where T : IComparable//heapifyıp ve heapifydown işlemlerinde IComporable'a ihtiyacımız vardır.
    {
        public T[] Array { get; private set; }
        private int position;
        //Koleksiyon içindeki eleman sayısına ihityacım olabilir
        public int Count { get; set; }
        //Yapıcı metodumuzu oluşturalım
        public BHeap()
        {
            Count = 0;//count ifademizi default olarak 0 değerine eşitleyelim.
            //Yapımızda 128 elemanlık default yer ayıralım.
            Array = new T[128];
            //ilk olarak hiçbir eleman olmayacğı için position eleamnını 0 default değer olarak atamasını yapalım.
            position = 0;
        
        }
        //constructer'ımızı aşıtır yükleyelim
        public BHeap(int _size)
        {
            Count=0;
            Array = new T[_size];
            position = 0;

        }
        //Zero based indeksleme( 0 tabanlı indeksleme mekanizması olacaktur.)

        //IEnumerable T şeklinde oluştutlmuş bir yapıyı doğrudan Binary Heap şeklinde yapılandırmaya yarayacak bir metod yazıyoruz.
        //ÖNEMLİ!!!
        public BHeap(IEnumerable<T> collection)
        {
            Count = 0;
            Array = new T[collection.ToArray().Length];
            position = 0;
            //KOleksiyondan gelen bütün işlemleri ekleme işlemi ile beraber.Binary Heap yapımızın içerisine atmış olacağız.
            foreach (var item in collection)
            {
                Add(item);
            }

        }

        //indeks tanımlaması için gerekli bir metodumuzu yazalım.
        //Düğümün sol çocuğunu bulmak için gerekli matematiksel hesaplama
        protected int GetLeftChildIndex(int i) => 2 * i + 1;
        //Düğümde seçilen indeksin sağ çosuğunu bulmak için gerekli denklemi tanımlayalım.
        protected int GetRightChildIndex(int i) => 2 * i + 2;

        //Child sayesinde Parent'ın indeksini bulmak için gerekli matematiksel hesaplamalrı yapan bir tanımlama yapalım.
        protected int GetParentIndex(int i) => (i-1)/2;//yuvarlam işlemi tam sayıya karşılık gelen kısma göre yapılacaktır.
        //Organizasyonlar için boolean değer tipli bir property oluşturalım.Örnek olarak x indeksli parent'ın 2x+2'de child' mevcutmudur sorusuna yanıt olarak böyle vir property'e ihtiyaç duyacağızdır.
        protected bool HasLeftChild(int i) => GetLeftChildIndex(i) < position;
        protected bool HasRightChild(int i) => GetRightChildIndex(i) < position;
        //Bu bir kök müdür sorusuna cevap alabilmek içingerekli property yazalım.
        protected bool IsRoot(int i) => i == 0;//dizinin ilk elemanı köktür.
        //Bir düğümün değerini bulmak için T şeklinde ifade edip değer döndürmesini sağlayacağız.
        protected T GetLeftChild(int i) => Array[GetLeftChildIndex(i)];
        protected T GetRightChild(int i) => Array[GetRightChildIndex(i)];
        protected T GetParent(int i) => Array[GetParentIndex(i)];

        //Boş olma durumu ve peek tanımlalması yapalım
        //Binary Heap boş olma durumunun tanımlanması 
        public bool IsEmpty() => position == 0;//position eklenecek elemanın indisini işaret eder.'0
                                               //'0' değerine sahip ise şuanda elemanlara ayrılan bölmenin
                                               //0. indeksi bile boştur anlamına gelmektedir.
                                               //Dolayısıyla IsEmpty True değer döndürecektir.
        //peek ifadesi,bir operasyon gerçekleşecekse eğer hangi ifade işlem görecektir 
        //sorusuna cevap olarak peek prperties yazalım.
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new Exception("Empty Blocks");
            }
            return Array[0];//silinecek bir ifade var ise bu kesinlikle root(kök) olmak zorundadır.
        }

        //değiştirilen Heap'ten sonra Heap property özelliği korunmak zorundadr.
        //Bunun için gerekli Metodu yazalım.Değiştirme işlemlerini yapan metod.
        //Takas işlemi(yer değiştirme) işlemini gerçekleştirelim.
        public void Swap(int first, int second)
        {
            var temp = Array[first];
            Array[first] = Array[second];
            Array[second] = temp;
        }
        //Ekleme ifadeleri için gerekli metodu yazalım
        public void Add(T Value)
        {
            if (position == 0)
            {
                throw new IndexOutOfRangeException("OverFlow");
            }
            else
            {
                Array[position] = Value;
                position++;
                Count++;
                HeapifyUp();//MinHeap ve MaxHeap için farklı çalışacaktır.
            }
        }
        
        public  T DeleteMinMax()
        {
            if (position == 0)
            {
                throw new IndexOutOfRangeException("Overflow");

            }
            else
            {
                var temp = Array[0];
                Array[0] = Array[position-1];
                position--;
                Count--;
                HeapifyDown();
                //Array[position-1] = temp;
                return temp;
            }
        }

        //Biz biliyoruzki ekleme işlemindeki heapifyup ve silme işlemindeki heapifyDown işlemleri farklı şekillerde yazılmaktadır.

        //abstarct bir property olduğu için sınıfında abstract tanımlanması gerekecektir.
        protected abstract void HeapifyUp();
        protected abstract void HeapifyDown();

        public IEnumerator<T> GetEnumerator()
        {
            return Array.Take(position).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


}


