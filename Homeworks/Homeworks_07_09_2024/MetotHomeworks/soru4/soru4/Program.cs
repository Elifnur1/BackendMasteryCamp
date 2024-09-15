using System.Xml;

namespace soru4;

class Program
{
    static int Not(int vize, int final)
    {
    
     int vize1=(vize*40)/100;
     int final1=(final*60)/100;
     int ortalama = (vize1 + final1);
     
     
     return ortalama;

    }
    static void Main(string[] args)
    {
        Console.WriteLine("Vize notunuzu girin: ");
        int input1=int.Parse(Console.ReadLine());
        Console.WriteLine("Final notunuzu girin:");
        int input2=int.Parse(Console.ReadLine());
        System.Console.WriteLine(Not(input1,input2));
        
        
    }
}
