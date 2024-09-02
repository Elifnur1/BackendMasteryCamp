namespace soru4;

class Program
{
    static void Main(string[] args)
    {
   
            Console.Write("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;

            while (sayi > 0)
            {
                int rakam = sayi % 10;
                toplam += rakam;
                sayi /= 10;
            }

            Console.WriteLine("Rakamların toplamı: " + toplam);
        }
    }
