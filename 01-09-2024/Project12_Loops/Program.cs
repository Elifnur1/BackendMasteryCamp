namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        //kullanıcıdan arka arkaya alınacak sayıları toplayan kodu hazırlayınız.Ancak kullanıcının girdiği sayıların toplamı 100 den büyük ya da eşitser program sona erip toplamı ekrana yazdoran kodu hazırlayın.

        /*int total=0;
        while(total <=100)
        {
            Console.Write("Bir sayı girin:");
            int inputNumber=int.Parse(Console.ReadLine());
            total += inputNumber;
        }
        Console.WriteLine(total);
        */

        //sadece sayı girişi yaptıralım
        /*
        ConsoleKeyInfo character;
        string resultNumber="";
        Console.Write("Bir karaker girin :");
        do
        {
            character =Console.ReadKey(true);
            if (char.IsDigit(character.KeyChar))
            {
                resultNumber += character.KeyChar.ToString();
                Console.Write(character.KeyChar.ToString());
            }
            
            else
            {
                if(character.Key==ConsoleKey.Backspace && resultNumber.Length >0)
                {
                    resultNumber=resultNumber.Substring(0,resultNumber.Length-1); //58745 = 5874
                    Console.Write("\b \b");
                }
            }
        } while (character.Key != ConsoleKey.Enter);
        */

        //girilen sayının asal sayı olup olmadığını tespit edip ekrana yazdırın.
        
        // bool isprime=true;
        // Console.Write("bir sayı girin: ");
        // int number=int.Parse(Console.ReadLine());
        // if (number <=1)
        // {
        //    isprime=false;
        // }
        // else
        // {
        //     for (int i = 2; i<number-1; i++)
        //     {
        //         if (number % i==0)
        //         {
        //             isprime=false;
        //             break;
        //         }
        //     }
        // }
        // Console.WriteLine(isprime==true ? "Asal" : "Asal değil.");


       




    }
}
