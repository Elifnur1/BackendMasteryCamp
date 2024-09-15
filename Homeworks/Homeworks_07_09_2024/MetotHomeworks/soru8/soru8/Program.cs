namespace soru8;

class Program
{
    static int Derece(int c)
    {
        int fah = (c * 9 / 5) + 32;
        System.Console.WriteLine(fah);
        return fah;

    }

    static void Main(string[] args)
    {
        Console.WriteLine("Bir derece girin: ");
        int Number=int.Parse(Console.ReadLine());
        Derece(Number);
    }
}
