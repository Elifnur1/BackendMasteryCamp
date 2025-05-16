namespace Project20_OOP_Intro;

class FirstClass
{
   //Buraya sınıfın özellik ve davranışlarını kodluyor olacağız.
   //Her class bir tiptir.
   //Özellik: Property
   //Davranış: Method

   //Public dışarıy açık
   //private:buraya özel(belirtilmezse default olarak private)
   //c# ta ki herşey objedir.
   public string message; //string tipinde message değişkeni oluşturduk.
   public string age;
   public void DisplayMessage()
   {
      System.Console.WriteLine(message);
   }
}

class Program
{
   static void Main(string[] args)
   {
      FirstClass firstClass1 = new FirstClass();
      firstClass1.message = "Selam";
      //System.Console.WriteLine(firstClass1.message);
      firstClass1.DisplayMessage();


   }
}
