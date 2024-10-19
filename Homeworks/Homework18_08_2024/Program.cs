using System.Security.Cryptography;

namespace Homework18_08_2024;

class Program
{
    static void Main(string[] args)
    {
        /* 1- `int` tipinde iki değişken oluşturun ve bu değişkenlere değerler atayın. Sonra bu değişkenleri toplayıp sonucu yeni bir değişkene atayın ve ekrana yazdırın.
        int a=12;
        int b=8;
        Console.WriteLine(a+b);*/


        /* 2-`double` tipinde bir değişken oluşturun ve bu değişkene bir ondalıklı sayı atayın. Bu sayının karesini hesaplayıp yeni bir `double` değişkene atayın ve sonucu ekrana yazdırın.
        double x=10.5d;
        double x_karesi=x * x;
        double x2= x_karesi;
        Console.WriteLine(x2);*/

        /*    3-`string` tipinde bir değişken oluşturun ve içine adınızı atayın. Sonra `int` tipinde bir değişken oluşturup yaşınızı atayın. Bu iki değişkeni kullanarak "Benim adım [ad] ve ben [yaş] yaşındayım." şeklinde bir cümle oluşturup ekrana yazdırın.
        string Myname="Elifnur";
        int Myage=23;
         string Myage2= Myage.ToString();
         Console.WriteLine(Myage2);
        string a= "Benim adım" + " " + Myname + " "+ "ve" + " " + "ben" + " " +Myage2 + " " + "yaşındayım.";
         Console.WriteLine(a);
        */

        /*  4-`char` tipinde bir değişken oluşturun ve içine bir harf atayın. Bu harfin ASCII değerini `int` tipinde bir değişkene atayıp ekrana yazdırın.
        char b='A';
        int b1=65;
        int b2=Convert.ToInt16(b1);
        Console.WriteLine(b1)*/

        /*   5-`bool` tipinde iki değişken oluşturun ve bunlara `true` ve `false` değerlerini atayın. Bu değişkenleri ekrana yazdırın.
        bool varMi=true;
        bool gecerliMi=false;
        Console.WriteLine(varMi);*/

        /*   6-`byte` tipinde bir değişken oluşturun ve içine 255 değerini atayın. Sonra bu değeri `int` tipine dönüştürüp yeni bir değişkene atayın ve ekrana yazdırın.
        byte Z=255;
        int Z2=Z;
        int Z3=Z2;
        Console.WriteLine(Z3); */

        /*   7-`int` tipinde bir değişken oluşturun ve içine büyük bir sayı (örneğin 1000000) atayın. Bu değeri `byte` tipine dönüştürmeye çalışın. Sonucu ekrana yazdırın ve ne olduğunu açıklayın.
        int Number=1000000;
        byte Numberbyte= Convert.ToByte(Number);
        byte Numberbyte2=Numberbyte;
        Console.WriteLine(Numberbyte2); 
        Anlık olarak dönüştürme yapıyor fakat çok büyük bir değeri çok küçük değere çevirdiği için ileride bu kod sana sorun veya hata çıkarabilir diyor.*/

        /*   8-`double` tipinde bir değişken oluşturun ve içine 3.14 değerini atayın. Bu değeri `int` tipine dönüştürüp yeni bir değişkene atayın ve sonucu ekrana yazdırın. Sonucu yorumlayın.
        double pi=3.14;
        int piInt=Convert.ToInt32(pi);
        int piInt2=piInt;
        Console.WriteLine(piInt2);*/


        /*   9-`string` tipinde bir değişken oluşturun ve içine bir sayı yazın (örneğin "42"). Bu string'i `int` tipine dönüştürüp yeni bir değişkene atayın ve ekrana yazdırın.
        string Value="42";
        int Value2=Convert.ToInt32(Value);
        Console.WriteLine(Value2); */

        /*   10- `int` tipinde üç değişken oluşturun ve bunlara sırasıyla 5, 10 ve 15 değerlerini atayın. Bu değişkenlerin ortalamasını hesaplayıp `double` tipinde bir değişkene atayın ve sonucu ekrana yazdırın.

        int number1=5;
        int number2=10;
        int number3=15;
        int average=(number1+number2+number3)/3;
        double average2=average;
        Console.WriteLine(average2); */

        /*  11-`decimal` tipinde iki değişken oluşturun ve bunlara para miktarları atayın (örneğin 10.25m ve 5.75m). Bu değerleri toplayıp sonucu yeni bir `decimal` değişkene atayın ve ekrana yazdırın.
        decimal money=10.25m;
        decimal money2=5.75m;
        decimal toplam_deger= money+money2;
        decimal money_toplam_deger=toplam_deger;
        Console.WriteLine(money_toplam_deger); */


        /*  12-`float` tipinde bir değişken oluşturun ve içine 1.23f değerini atayın. Bu değeri `double` tipine dönüştürüp yeni bir değişkene atayın. İki değeri de ekrana yazdırıp karşılaştırın.
       float number=1.23f;
       double number2=number;
       double number3=number2;
       Console.WriteLine(number3);*/


        /*  13-`long` tipinde bir değişken oluşturun ve içine çok büyük bir sayı atayın, örneğin 500000000000 gibi. Bu değeri `int` tipine dönüştürmeye çalışın. Sonucu ekrana yazdırın ve ne olduğunu açıklayın.
        long rate=5000000000;
        int newrate=Convert.ToInt32(rate);
        Console.WriteLine(newrate);  --Soru 7 deki gibi aynı uyarıyı verdi.*/

        /*  14-`string` tipinde iki değişken oluşturun ve bunlara adınızı ve soyadınızı atayın. Bu iki değişkeni birleştirip yeni bir `string` değişkene atayın ve ekrana yazdırın.
        string name="Elifnur";
        string surname="Binici";
        string name_surname= name + " " + surname;
        Console.WriteLine(name_surname); */

        /*  15- `string` tipinde bir değişken oluşturun ve içine "True" yazın. Bu string'i `bool` tipine dönüştürüp yeni bir değişkene atayın ve ekrana yazdırın.
        string gecerliMi="true";
        bool result=bool.Parse(gecerliMi);
        bool newresult=result;
        Console.WriteLine(newresult);*/

        /*  16-`double` tipinde pi sayısını temsil eden bir değişken oluşturun (3.14159). Bu değeri `float` tipine dönüştürüp yeni bir değişkene atayın. Her iki değeri de ekrana yazdırıp hassasiyet farkını gözlemleyin.

        double pi=3.14159007654;
        float newpi=Convert.ToSingle(pi);
        float newpi2=newpi;
        Console.WriteLine(newpi2); */

        /*  17-`byte`, `short`, `int`, ve `long` tiplerinde değişkenler oluşturun ve her birine aynı sayısal değeri (örneğin 42) atayın. Bu değişkenlerin bellekte kapladıkları alanı `sizeof()` operatörünü kullanarak ekrana yazdırın.`sizeof()` nasıl kullanılır, araştırın.
        byte number=42;
        short number2=42;
        int number3=42;
        long number4=42;
        Console.WriteLine(sizeof(byte));
        Console.WriteLine(sizeof(short));
        Console.WriteLine(sizeof(int));
        Console.WriteLine(sizeof(long)); */

        /*  18-`string` tipinde bir değişken oluşturun ve içine bir cümle yazın. Bu cümlenin karakter sayısını `int` tipinde bir değişkene atayıp ekrana yazdırın. (İpucu: `.Length` özelliğini kullanabilirsiniz, araştırın.)
        string love="Aleynayı çok seviyorum";
        int newlove=love.Length;
        Console.WriteLine("Dizgedeki karakter sayısı:" +newlove); */
















































    }
}
