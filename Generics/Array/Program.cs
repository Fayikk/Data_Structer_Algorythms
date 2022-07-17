using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var arr = new Generics.Array.Array<int>(1, 3, 5, 7);
            var crr =(Generics.Array.Array<int>)arr.Clone();//Yukarıda Generics dosyası içerisindeki Array classında bir atama yapmıştık.Ve tanımlama işlemini gerçekleştirdik.
                                                            //Array classına implemente ettiğimiz IClonable özelliği sayesinde,Clon metodunu implemente edebilecek duruma geldik.
                                                            //Ve bellekte oluşturduğumuz crr değişkenine Clone() metodu sayesinde atama işlemlerini gerçekleştirmiş olduk.
                                                            //FOREACH ile crr'nin klonlanan elmenalrını döndürmek için.
                                                            //Unboxing yapmak zorunda kalırız bu case işlemi yukarıda görüldüğü gibi yapılmaktadır.

            //Orjinal diziye eleman ekleyelim
            //Referans tipli bir tanımlama söz konusu değildir.
            arr.Add(98);
            
            
            foreach (var item in arr)
            {
                Console.WriteLine($"{item,-4}");
            }
           
            Console.WriteLine($"{arr.Count}/{arr.Capacity}");


            //foreach (var item in crr)
            //{
            //    Console.WriteLine($"{item,-4}");
            //} Bu ifadede hata alacağız.Hata almamak için bir tip dönüşümü yapmak zorundayız.

            //Unboxing işlemini gerçekleştirdikten sonra artık foreach ifadesi ile değer döndürme işlemini gerçekleştirebiliriz.

            
            foreach (var item in crr)

            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"{crr.Count}*{crr.Capacity}");
        }
    }
}
