namespace soru5;

class Program
{
    static string[] TersÇev(string[] name1)
    {
        foreach (var item in name1)
        {
            Console.WriteLine(item.ToUpper());
        }
        return name1;
    }
    static void Main(string[] args)
    {
       string[] input={"Burak", "Aleyna" , "Elif","Samet"};
       TersÇev(input);
        
    }
}
