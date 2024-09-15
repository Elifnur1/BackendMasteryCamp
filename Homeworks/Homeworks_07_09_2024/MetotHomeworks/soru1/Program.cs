namespace MetotHomeworks;

class Program
{
    static string Age(int yas)
    {
        string message;
        if(yas>=65)
        {
           message= "Emeklilik yaşındsınız.";
           Console.WriteLine(message);
        }
        else
        {
            message= "Çalışma yaşındasınız.";
            Console.WriteLine(message);
        }
        return message;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Yaşınızı girin:");
        int input=int.Parse(Console.ReadLine());
        Age(input);
        
    }
}
