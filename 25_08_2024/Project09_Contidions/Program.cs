using System.Security.Cryptography.X509Certificates;

namespace Project09_Contidions;

class Program
{
   static void Main(string[] args)
   {
      /*
       if(5>6)
       {

          Console.WriteLine("işlem tamamlandı.");

       }

       else
       {
           Console.WriteLine("hata");
       }
       Console.WriteLine("uygulama sona erdi.");*/


      //kullanıcının klavyeden gireceği yaş bilgisini alıp eğer eşit değilse "reşit değilsiniz, x sene sonra reşit olacaksınız." eğer reşit ise "Giriş yapabilirsiniz" yazdıran kodu hazırlayın

      //Console.WriteLine("Yaşınız:");
      //byte age=byte.Parse(Console.ReadLine());
      

      //if(age>=18)

      /*
      Console.Write("Adınızı giriniz:");
      string fullName=Console.ReadLine();

      Console.Write("yaşınızı girin:");
      byte age = byte.Parse(Console.ReadLine());

      //Ternary If yapısı;
      string resultmessage= age >= 18 ? $"Giriş yapabilirsin {fullName}": $" {18-age}yıl sonra reşit olacaksın,o zaman gel.{fullName}";
      Console.WriteLine(resultmessage);*/

      #region switch
      byte point = 75;
      byte resultpoint = 0;

      switch (point)
      {
         case < 45:
            resultpoint = 1;
            break;
         case < 55:
            resultpoint = 2;
            break;
         case < 70:
            resultpoint = 3;
            break;
         case < 85:
            resultpoint = 4;
            break;
         case < 100:
            resultpoint = 5;
            break;

         default:

            Console.WriteLine("lütfen 0-100 arası bir puan giriniz.");
            break;


      }
      Console.WriteLine(resultpoint);


      #endregion



   }
}
