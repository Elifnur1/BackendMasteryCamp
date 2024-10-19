namespace soru4;

class Program
{
    static void Main(string[] args)
        {
         //Kullanıcıdan alınan bir harfe göre sesli veya sessiz harf olduğunu belirleyen bir program yazın.

         Console.Write("Bir harf girin: ");
            string input = Console.ReadLine();

            if (input.Length == 1)
            {
                char harf = char.ToLower(input[0]);

                switch (harf)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        Console.WriteLine($"{harf} bir sesli harftir.");
                        break;
                    default:
                        Console.WriteLine($"{harf} bir sessiz harftir.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir harf girin.");
            }
            
        }
    }



