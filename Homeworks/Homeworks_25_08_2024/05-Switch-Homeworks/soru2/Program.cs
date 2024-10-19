namespace soru2;

class Program
{
    static void Main(string[] args)
    {
        //Kullanıcıdan alınan bir sayıya göre (1-12 arası) ayın adını yazdıran bir program yazın.
        
        Console.WriteLine("Bir sayı girin 1 ile 12 asrasında: ");
        string input=Console.ReadLine();

        int newInput;
        bool number=int.TryParse(input , out newInput);
        
        if (number)
        {
            string month;
            switch(newInput)
            {
                case 1:
                month="OCAK";
                break;

                case 2:
                month="ŞUBAT";
                break;

                case 3:
                month="MART";
                break;

                case 4:
                month="NİSAN";
                break;

                case 5:
                month="MAYIS";
                break;

                case 6:
                month="HAZİRAN";
                break;

                case 7:
                month="TEMMUZ";
                break;

                case 8:
                month="AĞUSTOS";
                break;

                case 9:
                month="EYLÜL";
                break;

                case 10:
                month="EKİM";
                break;

                case 11:
                month="KASIM";
                break;

                case 12:
                month="ARALIK";
                break;

                default:
                month="GEÇERLİ SAYI GİRİN";
                break;

            }
            Console.WriteLine($"girdiğiniz sayının karşılığı {month}");
        }
        else
        {
           Console.WriteLine("Geçersiz sayı girdini 1 ile 12 arasında değer girin");
        }
        
    }
}
