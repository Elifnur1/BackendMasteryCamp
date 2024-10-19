using System.Globalization;

namespace soru1;

class Program
{
    static void Main(string[] args)
    {
        //Kullanıcıdan alınan bir sayıya göre (1-7 arası) haftanın gününü yazdıran bir program yazın.
        
        Console.WriteLine("1 ile 7 arasında bir sayı girin(günleri belirtir): ");
        String input=Console.ReadLine();

        int daynumber;
        bool newInput=int.TryParse(input , out daynumber);
        if (newInput)
        {
            string day;
            switch(daynumber)
            {
                case 1:
                day="pazartesi";
                break;

                case 2:
                day="salı";
                break;

                case 3:
                day="çarşamba";
                break;

                case 4:
                day="perşembe";
                break;

                case 5:
                day="cuma";
                break;

                case 6:
                day="cumartesi";
                break;

                case 7:
                day="pazar";
                break;

                default:
                day="Geçersiz bir sayı girdiniz lütfen 1 ile 7 arasında girin:";
                break;


            }
            Console.WriteLine($"Haftanın günü {day}");
            
             }
        else
        {
          Console.WriteLine("Geçerli bir sayı girin.");
        }
    }
}
