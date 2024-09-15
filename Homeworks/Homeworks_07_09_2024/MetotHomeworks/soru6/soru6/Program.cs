using System.Data.SqlTypes;

namespace soru6;

class Program
{
    static string Number(int a)
    {
        string message;
        if( a % 2==0)
        {
           message="Girilen sayı çift sayıdır.";
           Console.WriteLine(message);
        }
        else
        {
            message="Girilen sayı tek sayıdır";
            Console.WriteLine(message);
        }
       return message;

       }
    static void Main(string[] args)
    {
       Number(6);
    }
}
