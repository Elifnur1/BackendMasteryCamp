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
    }
}
