namespace soru6;

class Program
{
    static void Main(string[] args)
    {
        //Kullanıcıdan alınan bir nota göre (A, B, C, D, F) geçme veya kalma durumunu belirleyen bir program yazın.

        Console.Write("Bir not girin (A, B, C, D, F): ");
        string input = Console.ReadLine().ToUpper();

        switch (input)
        {
            case "A":
                Console.WriteLine("Geçtiniz!");
                break;
            case "B":
                Console.WriteLine("Geçtiniz!");
                break;
            case "C":
                Console.WriteLine("Geçtiniz!");
                break;
            case "D":
                Console.WriteLine("Geçtiniz!");
                break;
            case "F":
                Console.WriteLine("Kaldınız!");
                break;
            default:
                Console.WriteLine("Geçersiz bir not girdiniz. Lütfen A, B, C, D veya F girin.");
                break;
        }
        
    }
}



