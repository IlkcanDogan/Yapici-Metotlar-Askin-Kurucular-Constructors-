using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapiciMetotlar
{
    /*
      * Bir sınıftan nesne oluşturulduğu an arkaplanda otomatik olarakç çalıştırılan metotlara
      * yapıcı metotlar denilmektedir. Bu yüzden nesne oluşturulduğunda otomatik olarak yapılmasını
      * istediğimiz işlemleri yapıcı metotların içerisine yazarız.
      * 
      * Yapıcı Metot Nasıl Tanımlanır?
      * 1-Yapıcı metotların ismi sınıf isimleriyle aynı olmak zorundadır.
      * 2-Public olarak belirtilmeleri gerekir.
      * 3-Geri dönüş değerleri yoktur.
      * 
      * "new Matematik()" ifadesi ile Matematik sınıfından bir nesne oluşturulduğu an yapıcı metot
      * otomatik olarak çalışacak ve field'lara içerisindeki değerleri atayacaktır.
      */
    class Matematik
    {
       
            //default olarak zaten erişim belirleyiciler private olarak belirlenir.
            double PI;
            double EulerSayisi;

            public Matematik()
            {
                PI = 3.1415;
                EulerSayisi = 2.7182;
            }
        
    }
}
