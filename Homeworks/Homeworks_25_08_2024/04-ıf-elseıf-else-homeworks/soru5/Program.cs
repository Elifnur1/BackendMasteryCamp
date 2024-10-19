namespace soru5;

class Program
{
        static void Main()
        {
        // Kullanıcıdan alınan üç sayının bir üçgen oluşturup oluşturamayacağını kontrol eden bir program yazın. (Geometride üçgen teorisini araştırınız.)

        Console.Write("Birinci kenarın uzunluğunu girin: ");
        string input1 = Console.ReadLine();

        Console.Write("İkinci kenarın uzunluğunu girin: ");
        string input2 = Console.ReadLine();

        Console.Write("Üçüncü kenarın uzunluğunu girin: ");
        string input3 = Console.ReadLine();

        double kenar1, kenar2, kenar3;
        bool validInput1 = double.TryParse(input1, out kenar1);
        bool validInput2 = double.TryParse(input2, out kenar2);
        bool validInput3 = double.TryParse(input3, out kenar3);

        if (validInput1 && validInput2 && validInput3)
        {
            bool üçgenMi = (kenar1 + kenar2 > kenar3) &&
                            (kenar1 + kenar3 > kenar2) &&
                            (kenar2 + kenar3 > kenar1);


            if (üçgenMi)
            {
                Console.WriteLine("Girilen kenar uzunlukları bir üçgen oluşturur.");
            }
            else
            {
                Console.WriteLine("Girilen kenar uzunlukları bir üçgen oluşturmaz.");
            }
        }
        else
        {
            Console.WriteLine("Geçerli bir sayı girin.");
        }
        
    }
}