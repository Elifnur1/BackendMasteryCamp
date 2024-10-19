namespace soru8;

class Program
{
    static void Main(string[] args)
    {
        //Kullanıcıdan alınan bir sayıya göre (0-6 arası) bir geometrik şeklin adını yazdıran bir program yazın (0: Nokta, 1: Çizgi, 2: Açı, 3: Üçgen, 4: Kare, 5: Beşgen, 6: Altıgen).

        Console.WriteLine("Bir sayı girin: ");
        string number=Console.ReadLine();

        int values;
        bool newValues=int.TryParse(number , out values);

        if(newValues)
        {
            switch(values)
            {
                case 0:
                Console.WriteLine("nokta");
                break;

                case 1:
                Console.WriteLine("çizgi");
                break;

                case 2:
                Console.WriteLine("açı");
                break;

                case 3:
                Console.WriteLine("üçgen");
                break;

                case 4:
                Console.WriteLine("kare");
                break;

                case 5:
                Console.WriteLine("beşgen");
                break;

                case 6:
                Console.WriteLine("altıgen");
                break;

                default:
                Console.WriteLine("Geçersiz bir sayı girdiniz!(0-6 arasında)");
                break;

            }
        }
        else
        {
            Console.WriteLine("Geçerli bir sayı giriniz");
        }
        
    }
}
