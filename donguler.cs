using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i;
            //for (i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("merhaba dünya");
            //}
            //Console.Read();


            //k++  veya  k+=1  veya k=k+1  artırma işlemlerini bunlardan biri yapabilirsin.


            //int j;

            //for (j = 0; j <= 20; j += 2)  //0 dan 20 ye kadar 2 şer atarak gitsin
            //{
            //    Console.WriteLine(j);
            //}
            //Console.Read();



            //int k;

            //for (k = 1; k <= 100; k += 1)
            //{
            //    Console.WriteLine(k + " Halo World");
            //}
            //Console.Read();


            //MOD kullanımı

            //int sayi;
            //Console.Write("sayıyı girin:");
            //sayi = Convert.ToInt16(Console.ReadLine());
            //if (sayi % 2 == 0)
            //{
            //    Console.Write("sayı çifttir");
            //}
            //else
            //{
            //    Console.Write("sayı tektir");
            //}

            //Console.Read();


            //int i;
            //for (i = 1; i <= 20; i ++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadLine();




            //TAM BÖLENLERİNİ BULMA  - ör: 20 tam bölenleri 1 2 4 5 10 20
            //int sayi;
            //Console.Write("sayı girin:");
            //sayi = Convert.ToInt16(Console.ReadLine());
            //for(int i = 1; i <= sayi; i++)
            //{
            //    if (sayi % i == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.Read();






            //ÖRNEK:bir bakteri her saatin sonunda kendini 2'ye bölerek çoğalıyor.yeniler de öyle.24 saatin sonunda kaç bakteri olur?
            //2,4 8 .... her saatin sonıunda böyle.   a.a.a.a....=a**n  n tane a yani   n de 24 olacak yani 2nin 24.kuvveti cvp

            //int bakteri = 1;
            //for(int i = 1; i <= 24; i++)
            //{
            //    bakteri = bakteri * 2;
            //    //console.WriteLine(bakteri);  buraya yazılınca her saatin sonunda kaç bakteri var alt alta verir
            //}
            //Console.WriteLine(bakteri);    //döngünün dışına yazılınca 24 saatin sonunda toplam bakteri sayısını verecek

            //Console.Read();







            //ARDIŞIK SAYILARLA İŞLEMLER
            //int toplam = 0;
            ////1 2 3 4 5
            ////0 1 3 6 10 15 -->toplam=toplam+i
            //for(int i = 1; i <= 5; i++)
            //{
            //    toplam = toplam + i;
            //    Console.WriteLine(toplam);    //alt alta her halini vererek toplar döngü içine yazarsan
            //}
            ////Console.WriteLine(toplam);   döngü dışına yazarsan da direk toplamı verir.
            //Console.Read();







            //FAKTÖRİYEL-   tam tersinden işletiyorum burdaa
            //int faktoriyel = 1;
            //for(int i = 5; i >= 1; i--) 
            //{
            //    faktoriyel = faktoriyel * i;
            //}
            //Console.WriteLine(faktoriyel);

            //Console.Read();


            //ÖDEV:Klavyeden girilen sayının faktöriyelini hesaplama
            //int sayi;
            //int faktoriyel = 1;
            //Console.Write("sayıyı girin: ");
            //sayi = Convert.ToInt16(Console.ReadLine());
            //for(int i = 1; i <= sayi; i++)
            //{
            //    faktoriyel = faktoriyel * i;
            //}
            //Console.WriteLine(faktoriyel);

            //Console.Read();




            ////WHİLE
            //int sayac = 1;
            //while (sayac <= 10)
            //{
            //    Console.WriteLine("merhaba turkcell videoları");
            //    sayac++;
            //}
            //Console.Read();


            //ÖRNEK: 1 ile 20 arasındaki sayıları listeleyen while döngüsü yazalım.
            //int sayi = 1;
            //while (sayi <= 20)
            //{
            //    Console.WriteLine(sayi);
            //    sayi++;
            //}
            //Console.Read();




            //ÖRNEK:1 ile 10 arasındaki sayıları toplayan whille döngüsü yapalım
            //int sayi = 1;
            //int toplam = 0;
            //while (sayi <= 10)
            //{
            //    toplam = toplam + sayi;
            //    sayi++;
            //}
            //Console.Write(toplam);

            //Console.Read();



            //ÖDEV:Klavyeden girilen sayının faktöriyelini while döngüsüyle hesapla.
            //int faktoriyel = 1;
            //int sayi;
            //int i = 1;
            //Console.Write("sayı girin:");
            //sayi = Convert.ToInt16(Console.ReadLine());
            //while (i <= sayi)
            //{
            //    faktoriyel = faktoriyel * i;
            //    i++;
            //}
            //Console.Write(faktoriyel);

            //Console.Read();




            //DO-WHİLE döngüsü normal while ile farkı whille da şart sağlanmazsa işlemlerr  gerçekleşmiyor
            //ama do-while da sağlanmasa bile en az bi kere gerçekleştiriyor

            //int sayi = 12;     // sağlanmaasa bile do daki olay gerçekleşti yani 12 yi yazdı sonra diper kısım olmadı
            //do
            //{
            //    Console.WriteLine(sayi);
            //    sayi++;
            //}
            //while (sayi <= 10);
            //Console.Read();
            








        }
    }
}
