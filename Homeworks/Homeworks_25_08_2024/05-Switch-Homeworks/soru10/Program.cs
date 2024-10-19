namespace soru10;

class Program
{
    static void Main(string[] args)
    {

         //Kullanıcıdan alınan bir karaktere göre (+, -, *, /, %) matematiksel işlemin  adını yazdıran bir program yazın.

          Console.Write("Bir matematiksel işlem karakteri girin (+, -, *, /, %): ");
            string input = Console.ReadLine();

            if (input.Length == 1)
            {
               char islem = input[0];

            switch (islem)
                {
                    case '+':
                        Console.WriteLine("Toplama işlemi");
                        break;
                    case '-':
                        Console.WriteLine("Çıkarma işlemi");
                        break;
                    case '*':
                        Console.WriteLine("Çarpma işlemi");
                        break;
                    case '/':
                        Console.WriteLine("Bölme işlemi");
                        break;
                    case '%':
                        Console.WriteLine("Mod alma işlemi");
                        break;
                    default:
                        Console.WriteLine("Geçersiz bir işlem karakteri girdiniz. Lütfen +, -, *, / veya % girin.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir tek karakter girin.");
            }
    
        }
    }


