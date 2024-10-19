namespace soru3;

class Program
{
    static void Main(string[] args)
    {
        //Kullanıcıdan alınan bir karakterin sesli harf olup olmadığını kontrol eden bir program yazın. (Veya (`||`) operatörünü araştırınız.)

        Console.Write("Bir karakter girin: ");
        char karakter = Console.ReadKey().KeyChar;

        Console.WriteLine();

        if (karakter == 'a' || karakter == 'e' || karakter == 'ı' || karakter == 'i' ||
            karakter == 'o' || karakter == 'ö' || karakter == 'u' || karakter == 'ü' ||
            karakter == 'A' || karakter == 'E' || karakter == 'I' || karakter == 'İ' ||
            karakter == 'O' || karakter == 'Ö' || karakter == 'U' || karakter == 'Ü')
        {
            Console.WriteLine($"{karakter} bir sesli harftir.");
        }
        else
        {
            Console.WriteLine($"{karakter} bir sesli harf değildir.");
        }
    }
}

