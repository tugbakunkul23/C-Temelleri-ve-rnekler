using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace metotlar
{
    internal class Program
    {
        //Geriye değer döndürmeyen metodlarda void tanımlaması yapılır.
        //Geriye değer döndüren metodlarda ise inti string veya sınıfa ait ilgili değerin tğrğ yazılır.

        ////GERİYE DEĞER DÖNDÜRMEYEN METODLAR
        //public static void yazdir()
        //{
        //    Console.Write("bu bir metottur");
        //    Console.WriteLine();
        //    Console.Write("burası metodun bir başka satırıdır.");
        //    Console.WriteLine();
        //}

        //public static void toplamametodu()
        //{
        //    int sayi1 = 24, sayi2 = 30;
        //    int toplam = sayi1 + sayi2;
        //    Console.Write(toplam);
        //}

        //public static void yazibosluk()
        //{
        //    Console.WriteLine();
        //    Console.Write("***************");
        //    Console.WriteLine();
        //}

        //public static void ardisiksayilar()
        //{
        //    for(int i = 1; i <= 10; i++)
        //    {
        //        Console.Write(i + " ");
        //    }
        //}

        ////VOİD METODLARDA PARAMETRE KULLANIMI
        //public static void MetinYaz(string p)
        //{
        //    Console.Write("***********");
        //    Console.WriteLine();
        //    Console.Write(p);
        //    Console.WriteLine();
        //    Console.WriteLine("***********");
        //}
        //public static void MetinYaz2(string parametre)
        //{
        //    Console.Write("--------------");
        //    Console.WriteLine();
        //    Console.Write(parametre);
        //    Console.WriteLine();
        //    Console.Write("--------------");
        //}

        //****************************************************************************************************************

        //Geriye değer döndüren metodlarda ise int,string veya sınıfa ait ilgili değerin türü yazılır.
        //Geriye dönecek değer return ifadesi ile belirlenir.

        public static int toplama()
        {
            int sayi1, sayi2, sonuc;
            sayi1 = 25;
            sayi2 = 35;
            sonuc = sayi1 + sayi2;
            return sonuc;
        }

        public static int toplam(int s1,int s2)
        {
            int sonuc;
            sonuc = s1 + s2;
            return sonuc;
        }





        static void Main(string[] args)
        {
            //yazdir();
            //Console.WriteLine("************");
            //toplamametodu();
            //yazibosluk();
            //ardisiksayilar();
            //MetinYaz("tuğba");
            ////
            //Console.Write("kelimeyi giriniz: ");
            //string kelime = Console.ReadLine();
            //MetinYaz2(kelime); 
            //Console.Read();
            //**********************************************************************************************

            Console.WriteLine(toplama());

            //parametreli geriye değer döndüren metod
            //Console.Write("Toplam: " + toplam(10, 15));
            //klavyeden veri girişi için
            int sayi1, sayi2;
            Console.Write("1.sayıyı giriniz: ");
            sayi1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("2.sayıyı giriniz: ");
            sayi2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Sonuç: " + toplam(sayi1, sayi2));
            Console.WriteLine(toplam(7, 8));

            Console.Read();


        }
    }
}
