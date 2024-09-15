namespace soru9;

class Program
{
    static int[] Dizi()
    {
       int[] newDizi={2,3,5,7,0,9,8};
       Array.Sort(newDizi);
       Console.WriteLine(newDizi[0]);
       return newDizi;

    } 
    static void Main(string[] args)
    {
       Dizi();
    }
}
