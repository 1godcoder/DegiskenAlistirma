using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegiskenAlistirma
{
    internal class Program
    {
        static void Main(string[] args)
        {

                       Console.WriteLine("Merhaba User!");

                      Console.Write("Adınızı Girin : ");
            string ad = Console.ReadLine();

                   Console.Write("Soyad Girin : ");
            string soyad = Console.ReadLine();

                     Console.Write("Şehir Girin ; ");
            string sehir = Console.ReadLine();

            //Yaş Stringi Int e Çeviriyoruz;
             Console.Write("Yaş Giriniz : ");
            string yasStr= Console.ReadLine();

            //Parse Yerine Convertte kullanabiliriz...
             int yasConvert = Convert.ToInt32(yasStr);
            int yasConvert2 = Convert.ToInt32(yasConvert);
       
            //int yasParse = int.Parse(yasStr);


            Console.Clear();

     Console.WriteLine("İsminiz : " + ad);

       Console.WriteLine("Soyadınız : " + soyad);
                         
        Console.WriteLine("Şehriniz : " + sehir);
                         
         Console.WriteLine("Yaşınız : " + yasConvert);

        
            

            Console.ReadLine();

        }
    }
}
