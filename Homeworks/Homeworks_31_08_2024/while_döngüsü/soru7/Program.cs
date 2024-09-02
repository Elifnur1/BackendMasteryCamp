namespace soru7;

class Program
{
    static void Main(string[] args)
    {
       
            Console.Write("Başlangıç değeri girin: ");
            int baslangicDegeri = Convert.ToInt32(Console.ReadLine());

            Console.Write("Üst sınır değeri girin: ");
            int ustSinir = Convert.ToInt32(Console.ReadLine());

            while (baslangicDegeri < ustSinir)
            {
                Console.WriteLine(baslangicDegeri);
                baslangicDegeri *= 2; 
            }
        }
    }

