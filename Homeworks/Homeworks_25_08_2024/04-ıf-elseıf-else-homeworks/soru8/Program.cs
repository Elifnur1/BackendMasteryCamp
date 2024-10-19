namespace soru8;

class Program
{
    static void Main(string[] args)
    {
        //Kullanıcıdan alınan bir sayının 3'e ve 5'e tam bölünüp bölünmediğini kontrol eden ve uygun mesajı veren bir program yazın.

        Console.WriteLine("Bir sayı giriniz: ");
        double input1=double.Parse(Console.ReadLine());

        if (input1%15==0)
        {
            Console.WriteLine($"{input1} 3'e ve 5'e tam bölünür.");
        }
        else
        {
          Console.WriteLine($"{input1} 3'e ve 5'e tam bölünmez!");
        }


    }
}
