namespace Project05_VariableSample;

class Program
{
    static void Main(string[] args)
    {
        #region Yaş hesaplama

        /*Yaş hesaplama
        -Kullanıcıdan  doğum yılını alıp yaşını hesaplayacak ve bunu ekrana yazdıracak kodu hazırlıyoruz.
        Console.Writeline("Doğum yılınızı giriniz:");
        string input = Console.ReadLine();

        int birthYear = int.Parse(input); //1975
        int calculatedAge = DateTime.Now.Year - birthYear;
        string message = "Yaşınız:" + calculatedAge;
        Console.WriteLine(message);
*/
        #endregion

        #region Ürün fiyatı hesaplama



        //Bir ürünün fiyatı girildiğinde, onun KDV dahil fiyatını hesaplayıp hem ham hem de KDV dahil fiyatını ekrana yazdıracağız.
        /*Console.WriteLine("Ürün fiyatı:");
        decimal productPrice= decimal.Parse(Console.ReadLine());

        double vatRate=0.18;
        double vat=(double)productPrice*vatRate;
        decimal totalProductPrice= productPrice + (decimal) vat;

        string resultMessage=$@"
        Ürün fiyatı      :{productPrice}
        KDV fiyatı       :{vat}
        KDV dahil fiyat  :{totalProductPrice}
        ";
        Console.WriteLine(resultMessage);*/





        #endregion

        #region Sıcaklık dönüştürme

        //Kullanıcıdan celsius cinsinden alınan sıcaklık değerini,Fahrenheit cinsine çevirip ekrana her ikisini de alt alta yazdıran kodu hazırlıyoruz.
        /*
        Console.WriteLine("C cinsinden sıcaklık değeri:");
        int celsius= int.Parse(Console.ReadLine());
        int newCelcius= (celsius * 9/5 )+ 32;

        string message=$@" 
        sonuç:
        -----
        C cinsinde sıcaklık:  {celsius}
        f cinsindeki sıcaklık:   {newCelcius}
       ";

       Console.WriteLine(message); */



        #endregion

        #region Ağırlık dönüştürme

        //Kullanıcının girdiği kg cinsinden ağırlığı gram'a çevirip sonucu ekrana yazdıran kodu hazırlıyoruz.
        //not:Küsüratlı değerler girilebilir.
        //not:Sonuç ekranında hem kg hem gr değerlerini düzgünce göstermemiz gerekiyor.

        Console.WriteLine("kg cinsinden değeri girin:");
        double kg = Convert.ToDouble(Console.ReadLine());
        double gr = kg * 1000;
        string resultmessage = $@"
        kg:   {kg}
        gr:  {(int)gr}";
        Console.WriteLine("sonuç:");
        Console.WriteLine("-----");
        Console.WriteLine(resultmessage);


        #endregion






    }
}
