using System.Security.Cryptography.X509Certificates;

namespace soru7;

class Program
{
    static void Main(string[] args)
    {
        //Kullanıcıdan alınan üç sayıdan en büyüğünü bulan bir program yazın.

        Console.WriteLine("Bir sayı girin:");
        double number1=double.Parse(Console.ReadLine());
        Console.WriteLine("İkinci sayıyı girin:");
        double number2=double.Parse(Console.ReadLine());
        Console.WriteLine("Üçüncü sayıyı girin: ");
        double number3=double.Parse(Console.ReadLine());

    
        if (number1>number2 && number1>number3)
        {
            Console.WriteLine($"en büyük sayı{number1}");
        }
        else if (number2>number3 && number2>number1)
        {
            Console.WriteLine($"en büyük sayı{number2}");
        }
        else
        {
            Console.WriteLine($"en büyük sayı{number3}");
        }

    }
}
