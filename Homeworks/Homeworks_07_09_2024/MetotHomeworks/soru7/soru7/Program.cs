namespace soru7;

class Program
{
    static string Time(int saat , int dk, int sn)
    {
        DateTime newTime=new DateTime(4 , 4, 4, saat,dk,sn);
        return newTime.ToString("HH:MM:ss");
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Bir saat girin(0-23 arasında): ");
        int newSaat=int.Parse(Console.ReadLine());
        Console.WriteLine("Dakikayı girin(0-59 arsında): ");
        int newDakika=int.Parse(Console.ReadLine());
        Console.WriteLine("Saniyeyi girin(0-59 arasında): ");
        int newSaniye=int.Parse(Console.ReadLine());
        Console.WriteLine(Time( newSaat, newDakika, newSaniye));
    }
}
