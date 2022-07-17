using System;
using System.Collections;//Koleksiyonlar
using System.Collections.Generic;//Generic koleksiyonlar
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_And_Collections
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Array
            //Dizi tanımlama
            char[] arrChar = new char[] {'f','a','y','i','k'};
            //dizi oluşturmanın farklı yolları
            var arrInt=Array.CreateInstance(typeof(int), 5);//5 elemanlı int tipinden array oluşturmak
            arrInt.SetValue(1,0);//setvalue ile değer atamsı yapıyoruz.ilk değerimiz tamsayı değerinin belirlerken y konumundaki değer dizideki indis'ini belirler
            arrInt.SetValue(2,1);
            arrInt.GetValue(0);//getvalue metodu ile set edilen işlemin değer döndürülmesi ekrana yazdırılması işlemleri gerçekleştirilir.


            //örtülü değişken tanımlama
            //var arrchar=new char[3];


            //ArrayList dinamik boyutlu tanımlama
            //type safe
            //10 ->boxing->object
            //
            var arrObj = new ArrayList();//ArrayList tanımlalamsı yaparak bellekte dinamik boyutlu bir liste elde etmiş olduk.
            arrObj.Add(10);
            arrObj.Add('b');//Burada hem int bir değer hemde char titpinde bir değer sakladığımızı görebiliriz.
            //Yani buda demek oluyorki tip güvenliğini kaybetmişiz demektir.
            var c = ((int)arrObj[0] + 20);//unboxing olayını gerçekleştirmeden örtülü olarak tanımlanmış bir arraylist ile int değişken tipini toplamasını yapayız.case işlemi yapıp değişken atamsaı yapılırsa her iki değişkende ayntı tipte olacağı için toplama gerçekleşir.

            //Arraylistlerde tamam daha dinamik bir ortam sağlayabildik.
            //Fakat bir dezavantajı var o da gördüğünüz üzere type-safe olmamasıdır(tip güvenliği kaybediyoruz 
            //bunuda faha güvenli type-safe uyumlu çalışan List<T> ile çözümleyebiliyoruz

            //List<T>
            //generic ifadeler. 
            var ArrInt = new List<int> ();
            ArrInt.Add(10);
            ArrInt.Add(01);
            ArrInt.AddRange(new int[] { 1, 2, 3, 4 });//Dizimiz dianmik olduğu için addrange metodu ile yaptığımız değer atama listesinide direkmen geçirmiş olacaktır.
            ArrInt.Add('b');// char değişken karşılığı olarakm bir int değer ataması yapmaktadır.
            ArrInt.Remove(1);
            var topla = ArrInt[0]+ArrInt[1];//burada ise tip güvenliği  sağa-lanmış vede dinamik bir bellek yönetimi için oratam sağlanmıştıur.

            Console.WriteLine(ArrInt[2]);
            Console.WriteLine(topla);
            Console.WriteLine(ArrInt[2]);










        }
    }
}
