using System.Windows.Markup;

namespace soru5;

class Program
{
    static void Main(string[] args)
    {
        //Kullanıcıdan alınan bir sayıya göre (1-4 arası) mevsim adını yazdıran bir program yazın.


        Console.WriteLine("Bir sayı giriniz (1 ile 4 arasında) : ");
        string input=Console.ReadLine();

        int newInput;
        bool season=int.TryParse(input, out newInput);
        if (season)
        {
            string values;
            switch(newInput)
            {
                case 1:
                values="İLKBAHAR";
                break;

                case 2:
                values="YAZ";
                break;

                case 3:
                values="SONBAHAR";
                break;

                case 4:
                values="KIŞ";
                break;

                default:
                values="Geçersiz sayı girdiniz";
                break;
            }
            Console.WriteLine($"Girilen değere karşılık gelen mevsim: {values}");
        }
        else
        {
            Console.WriteLine("Geçersiz sayı girdiniz (1-4 arasında girin)");
        }
        
    }
}
