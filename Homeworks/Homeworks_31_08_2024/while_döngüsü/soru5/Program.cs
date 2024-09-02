namespace soru5;

class Program
{
    static void Main(string[] args)
    {
  
            Console.Write("Pozitif bir tam sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int tersSayi = 0;

            while (sayi > 0)
            {
                int rakam = sayi % 10; 
                tersSayi = tersSayi * 10 + rakam; 
                sayi /= 10; 
            }

            Console.WriteLine("Sayının tersi: " + tersSayi);
        }
    }
