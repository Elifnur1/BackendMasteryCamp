namespace soru1;

class Program
{
    static void Main(string[] args)
    {
        //Kullanıcıdan alınan bir saati, 12 saat formatından 24 saat formatına (veya tam tersi) çeviren bir program yazın.

        Console.WriteLine("Bir sayı girin: ");
        string input=Console.ReadLine();

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
             else if(sayi==0)
             
                Console.WriteLine("Girilen sayı sıfıra eşit");
             
             else
             {
                Console.WriteLine("Geçerli sayı girin");
             }
             

        }
    }
}
