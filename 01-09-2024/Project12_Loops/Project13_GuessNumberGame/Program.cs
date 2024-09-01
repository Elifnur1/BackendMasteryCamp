using Microsoft.Win32.SafeHandles;

namespace Project13_GuessNumberGame;

class Program
{
    static void Main(string[] args)
    {
        string tekrar;
        do
        {


            Random rnd = new Random();
            int generatedNumber = rnd.Next(1, 100);
            Console.WriteLine($"HİLE=> {generatedNumber}");
            Console.WriteLine("**************");
            Console.WriteLine();

            int guessNumber;
            int live = 1;
            int liveLimit = 5;
            string resultMessage = "";

            do
            {
                Console.Write($"{live}. hak(1-100): ");
                guessNumber = int.Parse(Console.ReadLine());
                if (guessNumber < generatedNumber)
                {
                    resultMessage = "Daha büyük sayı giriniz!";
                }
                else if (guessNumber > generatedNumber)
                {
                    resultMessage = "Daha küçük bir sayı girin!";
                }
                if (guessNumber != generatedNumber)
                {
                    live++;
                }
                if (live <= liveLimit && guessNumber != generatedNumber) Console.WriteLine(resultMessage);  // if dögüsü tek satırsa süslü parantez açmaya gerek yok.
            } while (guessNumber != generatedNumber && live <= liveLimit);
            resultMessage = guessNumber == generatedNumber ? $"Kazandın:) \n Puanın:{(liveLimit - live) * 10}" : "Kaybettin";
            Console.WriteLine(resultMessage);
            Console.Write("Çıkış için ENTER");
            Console.WriteLine("Tekrar oynamak için E yazın");
            tekrar = Console.ReadLine();
        } while (tekrar == "E");

    }
}
/*
    sayı tahmin oyunu:
    uygulamanın rastgele üreteceğiz 1-100 arasındaki bir sayıyı kullanıcının tahmin ederek bulmasını ağlayan bir kod yazacağız.
    *kullanıcının tahmini üretilen sayıdan küçükse ya da büyükse buna göre yönlendirme yapılsın.
    *kullanıcının 5 tahmin hakkı olsun.
    *kullanıcı doğru tahmin yaptıysa ya da tahmin hakkı dolduysa uygun mesajı vererek oyun sona ersin.
*/
