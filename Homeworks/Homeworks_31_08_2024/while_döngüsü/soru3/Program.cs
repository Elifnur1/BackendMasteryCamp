namespace soru3;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir pozitif sayı girin: ");
        int number=int.Parse(Console.ReadLine());
        
        while (number>0)
        {
          int total=number*number;
        }
        Console.writeLine(total);
        else
        {
            Console.writeLine("Lütfen pozitif bir sayı girin:");
        }
    }
}
