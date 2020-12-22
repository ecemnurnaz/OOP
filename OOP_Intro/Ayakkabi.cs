
namespace OOP_Intro
{
    class Ayakkabi
    {
        //bir ayakkabının ........'sı olur.

        //Bir class tanımladığınız class içerisinde bulunan bütün değişkenlerin birer erişim belirleyicileri bulunmaktadır. 
        //Access Modifiers (Erişim Belirleyiciler)
        /*
            Public => Açık, (Her yerden ulaşılabilir.)
            Private=> Özel. Bir yapının başına private erişim belirleyicisi tanımlanırsa o yapı sadece bağlı bulunduğu class içerisinden ulaşılır.
            Internal=> internal olarak tanımlanan bir property ya da class sadece bağlı bulunduğu proje ieçrisinden ulaşılır.
        -------------------
            Protected=> protected oalrak işaretlenen bir yapı sadece miras alınan class'dan ulaşılabilir.
            Protected Internal=> miras alınan ve aynı proje içerisinde bulunan classlarda kullanılır.

            Class içerisinde tanımlanan değişkenler varsayılan olarak "private" şeklinde tanımlanır.
         */

       public int numara;
       public string renk;
       public decimal fiyat;
       public bool bagcikliMi;
       public string malzeme;
       public string marka;
       public string tip;

    }
}
