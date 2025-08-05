using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çok_boyutlu_dizilerr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Çok boyutlu diziler
            //int[,] sayilar = new int[2, 3];
            //sayilar[0, 0] = 10;
            //sayilar[0, 1] = 20;
            //sayilar[0, 2] = 25;
            //sayilar[1, 0] = 30;
            //sayilar[1, 1] = 40;
            //sayilar[1, 2] = 45;

            //Console.Write(sayilar[0, 1]);




            //Yıldızlarla şekil oluşturma
            //for (int i = 1; i <= 5; i++)
            //{
            //   for (int j = 1; j <= i; j++)
            //   {
            //       Console.Write("*");
            //   }
            //   Console.WriteLine();
            //}


            //hata yönetimi
            try
            {
                int sayi1, sayi2, sonuc;
                Console.Write("sayı 1:");
                sayi1 = Convert.ToInt16(Console.ReadLine());
                Console.Write("sayı 2:");
                sayi2 = Convert.ToInt16(Console.ReadLine());
                sonuc = sayi1 * sayi2;
                Console.Write("sonuç: " + sonuc);
            }
            catch(/*Exception ex*/FormatException)
            {
                //Console.WriteLine("hata var .lütfen formatınızı kontrol ediniz");
                Console.WriteLine("lütfen sadece sayısal değerler giriniz!");
                //Console.Write(ex);
            }
            catch (OverflowException)
            {
                Console.WriteLine("lütfen aralığın dışında değer girmeyin");
            }
            finally
            {
                Console.Write("burası çalıştı");
            }



            
            Console.Read();

        }
    }
}
