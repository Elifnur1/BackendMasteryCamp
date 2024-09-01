namespace soru4;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Bir yıl girin: ");
        int yil=Convert.ToInt32(Console.ReadLine());
        if ((yil%4)==0)
        {
            Console.WriteLine("Artık yıldır");
        }
        else
        {
           Console.WriteLine("Artık yıl değildir.");
        }
        Console.ReadKey();
    }
}
