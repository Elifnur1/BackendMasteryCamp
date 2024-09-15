namespace soru10;

class Program
{
    static int[] dizi()
    {
        int[] newDizi={0,7,11,2,4,7,9,10,9};
        System.Console.WriteLine(newDizi.Sum());
        return newDizi;
    }
    static void Main(string[] args)
    {
        dizi();
    }
}
