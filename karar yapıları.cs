using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karar_yapıları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string sehir;
            //Console.Write("şehir adı:");
            //sehir = Console.ReadLine();

            //if (sehir == "adana")
            //{
            //    Console.Write("doğru şehir");
            //}
            //else
            //{
            //    Console.Write("yanlış şehir");
            //}
            //Console.Read();



            //ÖĞrenci sınav-not uygulaması
            //int s1, s2, ort;
            //Console.Write("Sınav 1: ");
            //s1 = Convert.ToInt16(Console.ReadLine());
            //Console.Write("Sınav 2: ");
            //s2 = Convert.ToInt16(Console.ReadLine());
            //ort = (s1 + s2) / 2;
            //Console.WriteLine("Ortalamanız: " + ort);

            //if (ort >= 50)
            //{
            //    Console.Write("Geçtiniz...");
            //}
            //else
            //{
            //    Console.Write("Kaldınız...");
            //}

            //    Console.Read();



            //VE VEYA KULLANIMI
            //string kullanici, sifre;
            //Console.Write("Kulanıcı adınızı giriniz:");
            //kullanici = Console.ReadLine();
            //Console.Write("Şifrenizi giriniz: ");
            //sifre = Console.ReadLine();

            //if (kullanici=="admin" && sifre=="123456")    //  | düzz çizgi ile veyta durumunu da kullanabilirsin!
            //{
            //    Console.Write("Welcome :)");
            //}
            //else
            //{
            //    Console.Write("Eror!");
            //}

            //Console.Read();




            //ÇOKLU İF BLOĞU KULLANIMI
            //int s1, s2, s3, ort;
            //Console.Write("Sınav 1: ");
            //s1 = Convert.ToInt16(Console.ReadLine());
            //Console.Write("Sınav 2: ");
            //s2 = Convert.ToInt16(Console.ReadLine());
            //Console.Write("Sınav 3: ");
            //s3 = Convert.ToInt16(Console.ReadLine());
            //ort = (s1 + s2 + s3) / 3;
            //Console.WriteLine("Ortalamanız: " + ort);

            //if (ort <= 49)
            //{
            //    Console.Write("Durum :Vasat");
            //}
            //if (ort >= 50 & ort <= 65)
            //{
            //    Console.Write("Durum:Orta");
            //}
            //if(ort>=66 & ort <= 79)
            //{
            //    Console.Write("Durum:İyi");
            //}
            //if (ort >= 80)
            //{
            //    Console.Write("Durum:Çok iyi");
            //}


            //Console.Read();




           //BİLGİ YAARIŞMASI PORJESİ
            //Toplam soru sayısı:3  her soruda şık sayısı:4   diğer soruya geçebilmek için doğru cevap vermek gerekiyor.
            //Yanlış cevap verilince yarışma sona erer.3 sorunun tamamı doğru cevaplanırsa oyun biter.

            Console.WriteLine("Turkcell Bilgi Yarışmasına Hoşgeldiniz ");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();

            int soru = 1;
            string cevap;
            if (soru==1)
            {
                Console.WriteLine("Türkiyenin başkenti neresidir?");
                Console.WriteLine();
                Console.WriteLine("A)İstanbul");
                Console.WriteLine("B)Ankara");
                Console.WriteLine("C)Elazığ");
                Console.WriteLine("D)Bursa");
                Console.WriteLine();
                Console.Write("Cevabınız: ");
                cevap = Console.ReadLine();

                if (cevap=="b" || cevap == "B")
                {
                    soru = soru + 1;
                }
                else
                {
                    Console.Write("Cevap yanlış.Toplam puanınız:0");
                }

            }
            if (soru == 2)
            {
                Console.WriteLine("Cumhuriyet kaç yılında ilan edilmiştir?");
                Console.WriteLine();
                Console.WriteLine("A)1920");
                Console.WriteLine("B)1921");
                Console.WriteLine("C)1922");
                Console.WriteLine("D)1923");
                Console.WriteLine();
                Console.WriteLine("Cevabınız: ");
                cevap = Console.ReadLine();
                if(cevap=="d" || cevap == "D")
                {
                    soru = soru + 1;
                }
                else
                {
                    Console.Write("Cevabınız yanlış.Toplam puanınız:1");
                }
            }
            if (soru == 3)
            {
                Console.WriteLine("Adana hangi coğrafi bölgemizdedir?");
                Console.WriteLine();
                Console.WriteLine("A)Akdeniz");
                Console.WriteLine("B)Marmara");
                Console.WriteLine("C)Karadeniz");
                Console.WriteLine("D)İç Anadolu");
                Console.WriteLine();
                Console.WriteLine("Cevabınız: ");
                cevap = Console.ReadLine();
                if (cevap == "a" || cevap == "A")
                {
                    Console.Write("Tebrikler yarışma bitti.Bütün soruları doğru bildiniz...Toplam puanınız:3");
                }
                else
                {
                    Console.Write("Cevabınız yanlış,yarışma bitti.Toplam puanınız:2");
                }
            }




          

        }
    }
}
