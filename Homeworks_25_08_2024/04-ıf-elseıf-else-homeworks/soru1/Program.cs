namespace soru1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir sayı girin: ");
        string input=Console.Readline();

        double sayi;
        if (double.TryParse(input,out sayi))
        {
            if (sayi>0)
            {
                
                Console.WriteLine("Girilen sayı pozitif.");
      
            }
            else if(sayi<0)

                {
                    Console.WriteLine("Girilen sayı negatif");

                }
             else
             {

                Console.WriteLine("Girilen sayı sıfıra eşit");
             }
             else
             {
                Console.WriteLine("Geçerli sayı girin");
             }
             

        }
    }
}
