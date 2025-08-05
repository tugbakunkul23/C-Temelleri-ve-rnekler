using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //diziler değişkenlerden sonra köşeli parantez alıyor
            //string[] sehirler = { "adana", "elazığ", "ankara", "istanbul" };
            //Console.Write("Dizimizin 2.İndeks Değeri: " + sehirler[2]);

            //Console.Read();



            //int ile dizi
            //int[] sayilar = { 10, 20, 30, 40, 50, 60, 70 };
            //Console.WriteLine(sayilar[4]);
            //Console.Read();

            //dizinin bütün elemanlarını yazdırmak istersek

            //int[] sayilar = { 10, 20, 30, 40, 50, 60, 70 };
            //for(int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}
            //Console.Read();






            //dizilerle beraber karar yapısı kullanımı
            //int[] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            //for(int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] % 20 == 0 || sayilar[i] % 30 == 0)
            //    {
            //        Console.WriteLine(sayilar[i]);
            //    }
            //}
            //Console.Read();






            //Dizilerde toplama işlemi örneği
            //int [] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            //int toplam = 0;
            //for(int i = 0; i < sayilar.Length; i++)
            //{
            //    toplam += sayilar[i];
            //}
            //Console.WriteLine(toplam);

            //Console.Read();






            //METODLAR
            //sort metodu:küçükten büyüğe sıralar
            //int[] sayilar = { 20, 14, 12, 35, 13 };
            //Array.Sort(sayilar);
            //for(int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}
            //Console.Read();


            //Reverse metodu:dizimizi tersten sıralıyor.
            //string[] sehirler = { "adana", "ankara", "bursa", "elazığ", "malatya", "zonguldak" };
            //Array.Reverse(sehirler);
            //for(int i = 0; i < sehirler.Length; i++)
            //{
            //    Console.WriteLine(sehirler[i]);
            //}
            //Console.Read();




            //index of metodu
            //string[] kisiler = { "buse", "ali", "hakan", "furkan", "eylül" };
            //int sira;
            //Array.Sort(kisiler);
            //sira = Array.IndexOf(kisiler, "hakan");
            //Console.Write(sira);
            //Console.Read();




            //min max metodları
            //int[] sayilar = { 76, 43, 12, 56, 34 };
            //Console.WriteLine("En küçük sayı: " + sayilar.Min());
            //Console.Write("En büyük sayı: " + sayilar.Max());
            //Console.Read();






            //FOREACH DÖNGÜSÜ:dizilerle beraber kullanılan döngü türüdür.4 temel parametresi vardır.değişken türü,değişken adı,in komutu,dizi adı
            //string[] sehirler = { "ankara", "adana", "bursa", "izmir" };
            //foreach(string s in sehirler)
            //{
            //    Console.WriteLine(s);
            //}
            //Console.Read();




            //Foreach ve aritmetik işlemler
            //int[] sayilar = { 23, 55, 32, 16, 89, 70 };
            //int toplam = 0;
            //foreach(int i in sayilar)
            //{
            //    toplam += i;
            //}
            //Console.Write("Toplam:" + toplam);

            //Console.Read();

            //int[] sayilar = { 34, 22, 11, 67, 89, 50 };
            //Array.Sort(sayilar);
            //foreach(int sayi in sayilar)
            //{
            //    if (sayi % 2 == 0)
            //    {
            //        Console.WriteLine(sayi);
            //    }
            //}
            //Console.Read();




            //diziye klavyeden değer girme

            string[] sehirler = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Şehir ismi: ");
                sehirler[i] = Console.ReadLine();
            }
            for (int j=0; j < 5; j++)
            {
                Console.WriteLine(sehirler[j]);
            }


            Console.Read();







        }
    }
}
