using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STRİNG
            //string sehir, ilce; //birden fazla değişken tanımlanabilir
            // sehir = "Adana";
            //ilce = "Seyhan";
            //Console.Write(sehir + " " + ilce); 



            //İNT
            //int sayi;
            //sayi = 24;
            //Console.Write(sayi);


            //int sayi1, sayi2, toplam;
            //sayi1 = 12;
            //sayi2 = 25;
            //toplam = sayi1 + sayi2;
            //Console.Write(toplam);



            ////ARİTMETİK İŞLEMLER
            //int s1, s2, toplam, fark, carpım, bolum;

            //s1 = 23;
            //s2 = 10;
            //toplam = s1 + s2;
            //fark = s1 - s2;
            //carpım = s1 * s2;
            //bolum = s1 / s2;
            //Console.WriteLine("***** Aritmetik İşlemler *****");
            //Console.WriteLine();
            //Console.WriteLine("Toplam: " + toplam);
            //Console.WriteLine("Fark: " + fark);
            //Console.WriteLine("Carpım: " + carpım);
            //Console.WriteLine("Bolum: " + bolum);
            //Console.WriteLine();
            //Console.Write("***** Aritmetik İşlemler *****");


            //Console.Read();




            //DOUBLE sayı;
            //sayi = 24.9;
            //Console.WriteLine(sayi);

            //double s1, s2, ort;
            //s1 = 78;
            //s2 = 85;
            //ort = (s1 + s2) / 2;
            //Console.WriteLine(ort);
            //Console.Read();




            //KLAVYEDEN VERİ GİRİŞLERİ
            //string sehir,ilce;
            //Console.Write("Lütfen şehrinizi giriniz:");
            //sehir = Console.ReadLine();
            //Console.Write("Lütfen ilçeyi giriniz: ");
            //ilce = Console.ReadLine();
            //Console.WriteLine("Girdiğiniz şehir ve ilçe : " + sehir + "/" + ilce);

            //Console.Read();





            //CHAR:string birçok karaker üzerinde işlem yapabilirken char tek karakter üzerinde etki yapar.
            //char degisken;
            //degisken = 'a';  // a yerine '+'  , '6' felan da yazabilirsin ama tek karakter işte
            //Console.Write(degisken);

            //char secim;
            //Console.Write("Lütfen seçiminizi yapınız: ");
            //secim = Convert.ToChar(Console.ReadLine());
            //Console.Write("Seçiminiz: " + secim);

            //Console.Read();



            //FLOAT değişkenler
            //float sayi;
            //sayi=345.67f;
            //Console.Write(sayi);

            //float s1, s2, toplam;
            //Console.Write("Sayı 1: ");
            //s1 = float.Parse(Console.ReadLine());  //convert to demek yerine floatı başa yazıp parse ile devam ettiriyoruz.int parse da olabilirdi.
            //Console.Write("Sayı 2: ");
            //s2 = float.Parse(Console.ReadLine());
            //toplam = s1 + s2;
            //Console.Write(toplam);

            //Console.Read();




            //MİN MAX değerler
            //Console.WriteLine(byte.MaxValue);
            //Console.WriteLine(byte.MinValue);
            //Console.WriteLine(int.MinValue);
            //Console.WriteLine(int.MaxValue);
            //Console.WriteLine(float.MinValue);
            //Console.WriteLine(float.Max.Value);

            //Console.Read();




            //SHORT s1, s2, toplam;     iki sayının çarpımı şeklinde de hesaplanabilir.
            //s1 = 650;
            //s2 = 3456;
            //toplam = (short)s1 + s2;
            //Console.Write(toplam);

            //short a, b, c;
            //Console.Write("A:");
            //a = short.Parse(Console.ReadLine());
            //Console.Write("B:");
            //b = short.Parse(Console.ReadLine());
            //c = Convert.ToInt16(a + b);
            //Console.Write(c);

            //Console.Read();






            //BOOL durumları
            //bool durum;
            //durum = true;
            //Console.Write("Öğrenci sınavı geçti mi:");
            //Console.Write(durum);

            //bool uyemi;
            //Console.Write("Kullanıcı sisteme üye mi?:");
            //uyemi = Convert.ToBoolean(Console.ReadLine());
            //Console.Write("Kullanıcının sistem üyelik durumu: " + uyemi);

            //Console.Read();



            //DEĞİŞKENLER ÖRNEK
            string ad = "Tuğba";
            int yas = 23;
            double boy = 1.65;
            bool ogrenciMi = true;

            Console.WriteLine("Ad: " + ad);
            Console.WriteLine("Yaş: " + yas);
            Console.WriteLine("Boy: " + boy + " m");
            Console.WriteLine("Öğrenci mi? " + ogrenciMi);

            Console.Read();

             



        }
    }
}
