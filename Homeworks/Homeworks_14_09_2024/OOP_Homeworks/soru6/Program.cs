namespace soru6;
public class Calculater
{
    public double Add(double a, double b)
    {
        return a + b;
    }
    public double Subtract(double a, double b)
    {
        return a - b;
    }
    public double Multiply(double a, double b)
    {
        return a * b;
    }
    public double Divide(double a, double b)
    {
        if (b == 0)
            System.Console.WriteLine("Bölüm sıfır olamaz!");
        return a / b;
    }
}
class ScientificCalculator :Calculater
{
    public double Sin(double c)
    {
        return Math.Sin(c);
    }
    public double Cos(double c)
    {
        return Math.Cos(c);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculater calculater1=new Calculater();
        System.Console.WriteLine(calculater1.Add(2,8));
        System.Console.WriteLine(calculater1.Subtract(25,15));
        System.Console.WriteLine(calculater1.Divide(100,10));
        System.Console.WriteLine(calculater1.Multiply(5,2));
        ScientificCalculator scientificCalculator1=new ScientificCalculator();
        System.Console.WriteLine(scientificCalculator1.Sin(10));
        System.Console.WriteLine(scientificCalculator1.Cos(10));
        




    }
}
