namespace Project16_Methods;

class Program
{
    /*
        <Erişim Belirleyici> <Geri Dönüş Tipi> Method Adı(Parametre1_tipi parametre1_adı, parametre2_tipi parametre2_adı,....)
        {
           Metot Gövdesi
           İşlemleri burada gerçekleştiricez.
           return geri_döndürülecek_değer; 
           return ketworrdü sadece metot geriye bir değer döndürecekse kullanılır.
        }  
        DRY- Dont't Repeat Yourself
    */
    static void Greet()  //void kavramı 
    {
        Console.WriteLine("Merhaba Drogba");
    }

    static string Greet2(string name, bool gender)
    {
        if (gender)
        {
            return $"Merhaba {name} hanım :)";
        }
        else
        {
            return $"Merhaba {name} bey";
        }
    }

    static int Sum1()
    {
        int a = 40;
        int b = 50;
        int c = a + b;
        return c;

    }
    static int Sum2(int number1, int number2)
    {
        int result = number1 + number2;
        return result;
    }

    static double SumSqrt(double number1, double number2)
    {
        double total = number1 + number2;
        double result = Math.Sqrt(total);
        return result;
    }

    static void SampleNumberValue(int originalNumber)
    {
        originalNumber += 3;
        Console.WriteLine($"Metotun içindeki yazdırma satırı: {originalNumber}");
    }

    static void Bolme(int bolunen, int bolen, out int bolum, out int kalan)
    {
        bolum = bolunen / bolen;
        kalan = bolunen % bolen;

    }

    static void Main(string[] args)
    {
        int bolum;
        int kalan;
        Bolme(8, 3, out bolum, out kalan);
        Console.WriteLine($"8/3={bolum}\n8/3 işleminden kalan={kalan}");

        //Greet();

        //    Sum1();
        //    int x=Sum1();
        //    int y =Sum2(50, 70);
        //    int z=Sum2(90 ,250);
        //    Console.WriteLine(x + y + z);

        // double result1 =SumSqrt(4,12); //4
        // double result2 =SumSqrt(5,11); //4
        // double result3 =SumSqrt(2,23); //5
        // double result4 = SumSqrt(7,42); //7

        // Console.WriteLine(Greet2("Tuna", true));
        // Console.WriteLine(Greet2("Ahmet" ,false));

        // int originalNumber=15;
        // Console.WriteLine ($"Metot çağırmadan önceki originalNumber değeri: {originalNumber}");

        // SampleNumberValue(originalNumber);






    }
}
