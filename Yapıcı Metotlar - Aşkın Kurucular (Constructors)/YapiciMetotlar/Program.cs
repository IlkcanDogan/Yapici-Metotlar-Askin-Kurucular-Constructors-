using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapiciMetotlar
{  
    class Program
    {
        static void Main(string[] args)
        {
            //Yapıcı metoda paramtereler nesne oluşturulurken gönderildi.
            Ogrenci ogr1 = new Ogrenci("İlkcan Doğan", 202, 4);
            Ogrenci ogr2 = new Ogrenci("Ferdi Çalışkan", 127, 3);

            ogr1.Yaz();
            Console.WriteLine("\n");

            ogr2.Yaz();

            Console.ReadLine();

        }
    }
}
