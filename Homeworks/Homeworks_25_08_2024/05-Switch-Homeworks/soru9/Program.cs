namespace soru9;

class Program
{
    static void Main(string[] args)
    {
        //Kullanıcıdan alınan bir sayıya göre (1-5 arası) Türkçe sayı sıfatını yazdıran bir program yazın (1: Birinci, 2: İkinci, vb.).

        Console.WriteLine("Bir sayı girin (1 - 5 arası):");
        string input=Console.ReadLine();
        int number;
        bool newInput=int.TryParse(input , out number);
        if( newInput)
        {
            switch(number)
            {
                case 1:
                Console.WriteLine("birinci");
                break;

                case 2:
                Console.WriteLine("ikinci");
                break;

                case 3 :
                Console.WriteLine("üçüncü");
                break;

                case 4:
                Console.WriteLine("dördüncü");
                break;

                case 5:
                Console.WriteLine("beşinci");
                break;

                default:
                Console.WriteLine("Geçersiz bir sayı girdiniz!");
                break;

            }
        }
        else
        {
            Console.WriteLine("Geçerli bir sayı girin");
        }
    }
}
