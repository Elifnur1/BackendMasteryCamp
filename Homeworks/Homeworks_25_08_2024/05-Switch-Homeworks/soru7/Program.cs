namespace soru7;

class Program
{
    static void Main(string[] args)
    {
        //Kullanıcıdan alınan bir sayıya göre (1-5 arası) Türk para biriminin adını yazdıran bir program yazın (1 Kr, 5 Kr, 10 Kr, 25 Kr, 50 Kr).

        Console.WriteLine("Bir sayı giriniz (1-5 arasında): ");
        string input = Console.ReadLine();

        int values;
        bool newInput = int.TryParse(input, out values);
        if (newInput)
        {
            switch (values)
            {
                case 1:
                    Console.WriteLine("1 Kr");
                    break;

                case 2:
                    Console.WriteLine("5 Kr");
                    break;

                case 3:
                    Console.WriteLine("10 Kr");
                    break;

                case 4:
                    Console.WriteLine("25 Kr");
                    break;

                case 5:
                    Console.WriteLine("50 Kr");
                    break;

                default:
                    Console.WriteLine("Geçersiz bir sayı girdiniz!");
                    break;

            }
        }
        else
        {
            Console.WriteLine("Geçerli bir sayı girin.");
        }



    }
}
