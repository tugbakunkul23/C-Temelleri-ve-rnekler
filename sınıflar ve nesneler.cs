using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınıflar ve nesneler
{
     //SINIF VE NESNE:Amaç: Sınıf tanımı, özellikler (properties), nesne oluşturma ve metot kullanımı
    class Person
    {
          public string Name;
          public int Age;

          public void Introduce()
          {
               Console.WriteLine($"Merhaba, ben {Name}, {Age} yaşındayım.");
          }
     }

     class Program
     {
           static void Main()
           {
               Person p1 = new Person();
               p1.Name = "Tuğba";
               p1.Age = 23;
               p1.Introduce();
           }
     }



     //KAPSÜLLEME:Amaç: private alanlar ile dışarıdan doğrudan erişim engelleniyor.

     class Termos
     {
         private double sicaklik;

         public void SetSicaklik(double yeniSicaklik)
         {
             if (yeniSicaklik >= 0 && yeniSicaklik <= 100)
             {
                 sicaklik = yeniSicaklik;
             }
             else
             {
                  Console.WriteLine("Geçersiz sıcaklık! 0-100 arası değer girin.");
             }
        }

              public double GetSicaklik()
              {
                  return sicaklik;
              }
      }

      class Program
      {
          static void Main()
          {
              Termos termos = new Termos();

              termos.SetSicaklik(80); // Geçerli sıcaklık
              Console.WriteLine("Termostaki sıcaklık: " + termos.GetSicaklik() + "°C");

              termos.SetSicaklik(150); // Geçersiz sıcaklık
              Console.WriteLine("Termostaki sıcaklık: " + termos.GetSicaklik() + "°C");
          }
       }





       //KALITIM:Amaç: Bir alt sınıf, üst sınıftan tüm özellikleri alır (miras alır).

        class Hayvan
        {
            public string Ad;

            public void SesCikar()
            {
                 Console.WriteLine("Bir hayvan sesi çıkardı.");
            }
        }

        class Kedi : Hayvan
        {
            public void Miyavla()
            {
                  Console.WriteLine($"{Ad} miyavladı.");
            }
        }

        class Program
        {
             static void Main()
             {
                  Kedi k = new Kedi();
                  k.Ad = "Tekir";
                  k.SesCikar(); // Kalıtım sayesinde kullanılabilir
                  k.Miyavla();
             }
         }




         //POLİMORFİZM:Amaç: Aynı metot adıyla farklı davranışlar (override) gösterme.

         class Sekil
         {
              public virtual void Ciz()
              {
                  Console.WriteLine("Bir şekil çiziliyor...");
              }
         }

         class Kare : Sekil
         {
              public override void Ciz()
              {
                   Console.WriteLine("Kare çiziliyor...");
              }
         }

         class Daire : Sekil
         {
              public override void Ciz()
              {
                    Console.WriteLine("Daire çiziliyor...");
              }
         }

         class Program
         {
              static void Main()
              {
                  Sekil sekil1 = new Kare();
                  Sekil sekil2 = new Daire();

                  sekil1.Ciz(); // Kare çiziliyor...
                  sekil2.Ciz(); // Daire çiziliyor...
              }
         }



        



  
}
