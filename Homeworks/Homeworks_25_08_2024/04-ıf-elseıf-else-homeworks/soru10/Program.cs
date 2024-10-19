namespace soru10;

class Program
{
    static void Main(string[] args)
    {
        //Kullanıcıdan alınan bir sayının asal olup olmadığını kontrol eden bir program yazın.
        //??

        Console.WriteLine("Bir sayı giriniz: ");
        double input=double.Parse(Console.ReadLine()); 

        if (input % input==0 && input%1==0)
        {
            Console.WriteLine($"{input} bir ASAL sayıdır.");
        }   
        else
        {
            Console.WriteLine($"{input} bir asal sayı değildir!");
        }
    
    }
}
