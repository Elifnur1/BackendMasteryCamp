using Microsoft.VisualBasic;

namespace Project03_Variables;

class Program
{
    static void Main(string[] args)
    {
        #region Tam sayılar
        /*  // int degiskenAdi=56;
   // int degiskenAdi2;
   // System.Console.WriteLine("degiskenAdi");


   // VS Code: Line Comment shift+command +7
   // Evrensel : Line option+shift+A  


   // Tam sayılar;

/* C# ta AYRICA BELİRTİLMEDİKÇE TÜM  SAYISAL DEĞERLER İNT TİPİNDE VARSAYILIR!*/
       // sbyte studentpoint = 127;
       // System.Console.WriteLine(studentpoint);

        // sbyte kavramına -128 den 127 e kadar değer alabiliyor 128 olamaz kuraldır..Bellekte kaapladığı yer 1 byte(8bit)

       // byte studentPoint2 = 255; //byte 0 ile 255 arası değer alabilir. 1 byte (8bit)

        //System.Console.WriteLine(studentPoint2);
       /* short price = -500; //16 bit -, + değer alabilir
        ushort price2 = 600; //16 bit sadece + değer alabilir. yukarıdaki sayı tiplerine göre 2 kat büyüklüktedir ve daha çok sayısal değer alır.
        int number = -589; //32 bit -,+ değer alabilir
        uint number2 = 97; // sadece + değer alabilir.
        long longnumber = -98897987; //64bit +,- değer alabilir
        ulong longnumber2 = 545; // 64 bit - değer alamazz!! */
        #endregion


        #region Ondalık Sayılar

        //Ondalık Sayılar
        /*float oran=0.5f; //32 bit, hassasiyeet:7basamak
        //float değer yazarken sayının yanına küçük veya büyük harfle 'f' yazılmalı.
        double oran2=0.5;//64 bit, hassasiyet:15-16 basamak
        decimal maaş=0.5m; //decimal olarak m harfi kullanılmalı. 128 bit, hassasiyet:28-29 basamak*/

        #endregion

        #region Diğer Tipler
       /*bool varmi = true;
        bool gecerlimi = false; //8bit

        char cevap = 'H'; // char kavramında sadece tek bir karakter tutabilir ve tek tırnak içine yazılmalı kuraldır!
        char sembol = '8'; //UTF-16 charset,16 bit
        */
    

        #endregion


        #region Value Types (Değer Tipler)
        /* Yukarıdaki tüm tiplere c# Value Types der.
        Value types ,bellekte içinde direkt olarak değer saklayan yapıları anlatır.
        Ayrıca bunlara Primitive types da denir.*/


        #region Reference types (referans tipler)
        /* Ram in stack kısmında verinin yerine,verinin bulunduğu yerin adresini tutan veri tipleridir.
        Yani bir reference type,bir nesneyi ya da değeri işaret eder.*/

        #endregion


        #region Temel referans tipler

       // string adSoyad = "Elifnur Binici";
        //object nesne = 15;
       // object nesne2 = true;
       // object nesne3 = "merhaba";
        //String ve Object tiplerinin bellekte ne kadar yer kapladığını araştırınız.


        #endregion


        #region Değişken isimlendirme kural ve teknikleri

        /* 
        1) C# büyük/küçük harf duyarlı bir dildir.
        Ör: adSoyad ile AdSoyad aynı değildir!
        2) Özel karakterler değişken adı içerisinde yer alamaz. Alt tire(_)hariç.
        Ör:Ad Soyad , Oğrenci-Numarası , 1Sayi , 4not bunlar geçersiz isimlerdir. Çünkü değişken ismi harf ya da alt tire ile başlamak zorundadır!
        ör:_AdSoyad,Sayı_1 Sayı_1
        3) Anahtar sözcükler yani C# özel anlam yüklediği sözcükler değişken ismi olarak kullanılamaz.
        öR: int static; , string void; ...
        4) Değişkenler anlamlı bir şekilde isimlendirilmeli.
        Ör: string AdSoyad;
        5) Değişken isimlendirirken camelcase tekniği kullanılmalıdır.
        Ör: string anneadi; string anneAdi; string anne_adi  CAMELCASE'e uygundur.bunlar camelcase'e uygun değil.
        6) Değişken isimlendirirken türkçe karakter kullanmak yasak değil.Ancak tercih etmemeyi şiddetle öneriyoruz.
        7) Sabit(Const) tanımlarken genellikle TAMAMEN BÜYÜK HARF kullanılır.
        ör: const int MAX_AGE=40;
        ör: const double PI=3.14;
        

        */
        #endregion


    
    

    
        
       