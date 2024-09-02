namespace Project18_MethodSamples;

class Program
{

    //Kendisine gönderilen int tipindeki sayı listesinde yer alan negatif sayıları geri döndüren bir metot hazırlayalım.
    static List<int> GetNegativeNumbers(List<int>numbers)
    {
         List<int> negativeNumbers = new List<int>();
     foreach (var number in numbers)
         {
             if(number<0)
             {
                 negativeNumbers.Add(number);
             }
         }
         return negativeNumbers;

     }

    static int TotalOfSquaers(int a, int b)
    {
        int karesi = a * a;
        int karesi2 = b * b;
        int total = karesi + karesi2;
        return total;
    }

    static void Main(string[] args)
    {
         List<int> numbers=[5 ,7 ,-5 ,-4 ,3 ,-12 ,4 ,5, 7];
         List<int> resultNumbers=GetNegativeNumbers(numbers);
         foreach (var number in resultNumbers)
         {
            Console.WriteLine(number);
        }
        System.Console.WriteLine(TotalOfSquaers(5,7));

    }

    //TotalOfSquaers(5,7); 5 ve 7. nin karelerini bulup toplayıp geri döndüren metot.
}

