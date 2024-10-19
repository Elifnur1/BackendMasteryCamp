namespace soru3;

class Program
{
    static void Main(string[] args)
    {
        //Kullanıcıdan alınan iki sayı ve bir işlem(+, -, *, /) için basit bir hesap makinesi yapın(switch kullanarak).

        Console.Write("İlk sayıyı girin: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("İkinci sayıyı girin: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Yapılacak işlemi girin (+, -, *, /): ");
        char islem = Convert.ToChar(Console.ReadLine());
        double sonuc = 0;
        switch (islem)
        {
            case '+':
                sonuc = sayi1 + sayi2;
                break;
            case '-':
                sonuc = sayi1 - sayi2;
                break;
            case '*':
                sonuc = sayi1 * sayi2;
                break;
            case '/':
                if (sayi2 != 0)
                {
                    sonuc = sayi1 / sayi2;
                }
                else
                {
                    Console.WriteLine("Bölen 0 olamaz.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Geçersiz işlem operatörü.");
                return;
        }
        Console.WriteLine($"Sonuç: {sonuc}");
    }

}

