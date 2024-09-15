namespace soru2;

class Program
{
    static string kıyas(int sayı1, int sayı2)
    {
        string message;
        if(sayı1>sayı2)
        {
           message="İlk sayı daha büyüktür.";
           Console.WriteLine(message);
        }
        else
        {
           message="İkinci sayı daha büyüktür.";
           Console.WriteLine(message);
        }
        return message;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("İki sayı giriniz: ");
        int input=int.Parse(Console.ReadLine());
        int input2=int.Parse(Console.ReadLine());
        kıyas(input,input2);
    
        
    }
}
