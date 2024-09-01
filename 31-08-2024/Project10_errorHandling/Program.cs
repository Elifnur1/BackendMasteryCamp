using System.Xml.XPath;

namespace Project10_errorHandling;

class Program
{
    static void Main(string[] args)
    {
        #region Try Catch Syntax
        /*
         try
         {
            
         }
         catch (System.Exception)
         {
            
            throw;
         }
         */

        #endregion

        #region Try Catch
        /*

        try
        {
            Console.Write("1.sayı:");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("2.sayı:");
            int number2 = int.Parse(Console.ReadLine());
            int result = number1 / number2;
            Console.WriteLine(result);
        }
        catch (FormatException)
        {
            Console.WriteLine("Lütfen geçerli bir değer girin.");
        }
        catch (OverflowException)
        {
            Console.WriteLine($"Lütfen {int.MinValue} -{int.MaxValue} arasında bir değer girin.");
        }
        catch (DivideByZeroException)
        {
            number1;
            Console.WriteLine();
        }*/

        #endregion
    }
}
