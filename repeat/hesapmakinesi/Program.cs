using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            System.Console.WriteLine("\n1.sayıyı gir:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("2.sayıyı gir:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("işlem seçin(+,-,*,/):");
            string işlem = Console.ReadLine();
            if (işlem.ToLower() == "çık")
            {
                System.Console.WriteLine("çıkış yapılıyor..");
                break;
            }
            int result = 0;

            if (işlem == "+")
            {
                result = Topla(number1, number2);
            }
            else if (işlem == "*")
            {
                result = Çarp(number1, number2);
            }
            else if (işlem == "-")
            {
                result = Çıkar(number1, number2);
            }
            else if (işlem == "/")
            {
                if (number2 != 0)
                    result = Böl(number1, number2);
                else
                    System.Console.WriteLine("0 'a bölme hatası!");
            }
            else
            {
                System.Console.WriteLine("Geçersiz işlem seçildi.");
            }
            System.Console.WriteLine("Sonuç:" + result);

            static int Topla(int a, int b)
            {
                return a + b;
            }
            static int Çıkar(int a, int b)
            {
                return a - b;
            }
            static int Çarp(int a, int b)
            {
                return a * b;
            }
            static int Böl(int a, int b)
            {
                return a / b;
            }
        }

        
    }
}


