using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapiciMetotlar
{
    class Ogrenci
    {
        /*
         * Sıradan metotlar gibi yapıcı metotlarda parametre alabilmektedir. Ancak yapıcı metotlar nesne
         * oluşturulduğu an çalıştığı için parametreler nesne oluşturulurken girilmelidir.Parametresiz olarak
         * yapıcı metot tanımlanmış ise nesne örneği alınırken parametre vermeden de kullanılabilirler. Sınıf ilk
         * çalışmaya başladığında yapılmasını istediğimiz işlemleri buraya yazarız.
         */

        string adSoyad;
        int numara;
        int sinif;

        // Nesne oluşturulurken girilen parametreler ile ilgili özellikler atanacaktır.
        public Ogrenci(string ogrAdi, int ogrNumara, int ogrSinif)
        {
            adSoyad = ogrAdi;
            numara = ogrNumara;
            sinif = ogrSinif;
        }

        public void Yaz() 
        {
            Console.WriteLine("Adı ve Soyadı: {0}\nNumara: {1}\nSınıfı: {2}",adSoyad,numara,sinif);
           
        }
    }
}
