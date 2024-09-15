namespace soru3;

class Program
{
    static string TersCevir(string kelime)
    {
        char[] karakterler = kelime.ToCharArray();

        Array.Reverse(karakterler);

        string tersKelime = new string(karakterler);

        return tersKelime;
    }

    static void Main(string[] args)
    {
        Console.Write("Bir kelime giriniz: ");
        string girisKelime = Console.ReadLine();

        string tersKelime = TersCevir(girisKelime);

        Console.WriteLine("Ters çevrilmiş kelime: " + tersKelime);
    }
}



