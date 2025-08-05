using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dosya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StreamWriter sw = new StreamWriter("C:\\Users\\Monster\\OneDrive\\Desktop\\deneme.txt");
            //string metin;
            //Console.Write("Metni Giriniz: ");
            //metin = Console.ReadLine();
            //sw.WriteLine(metin);
            //sw.Close();

            //DOSYA OKUMA
            FileStream fs = new FileStream("C:\\Users\\Monster\\OneDrive\\Desktop\\deneme2.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string metin = sr.ReadLine();
            while (metin != null)
            {
                Console.WriteLine(metin);
                metin = sr.ReadLine();
            }
            sr.Close();
            fs.Close();



            Console.Read();
        }
    }
}
