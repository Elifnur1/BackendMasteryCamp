namespace soru9;

class Program
{

    static void Main()
    {
        //Kullanıcıdan alınan iki sayı ve bir işlem (+, -, *, /) için basit bir hesap makinesi yapın.

        Console.Write("Birinci sayıyı girin: ");
        string input1 = Console.ReadLine();

        Console.Write("İkinci sayıyı girin: ");
        string input2 = Console.ReadLine();

        Console.Write("İşlem türünü girin (+, -, *, /): ");
        string islem = Console.ReadLine();

        double sayi1, sayi2;
        bool validInput1 = double.TryParse(input1, out sayi1);
        bool validInput2 = double.TryParse(input2, out sayi2);

        if (validInput1 && validInput2)
        {
            double sonuc = 0;
            bool islemGeçerli = true;

            if (islem == "+")
            {
                sonuc = sayi1 + sayi2;
            }
            else if (islem == "-")
            {
                sonuc = sayi1 - sayi2;
            }
            else if (islem == "*")
            {
                sonuc = sayi1 * sayi2;
            }
            else if (islem == "/")
            {
                if (sayi2 != 0)
                {
                    sonuc = sayi1 / sayi2;
                }
                else
                {
                    Console.WriteLine("Bir sayı sıfıra bölünemez.");
                    islemGeçerli = false;
                }
            }
            else
            {
                Console.WriteLine("Geçersiz işlem türü. Lütfen +, -, * veya / girin.");
                islemGeçerli = false;

            }
            if (islemGeçerli)
            {
                Console.WriteLine($"Sonuç: {sonuc}");
            }
        }
        else
        {
            Console.WriteLine("Geçerli bir sayı girin.");
        }
        
    }
}
