using Project24_Interface.Interfaces;

namespace Project24_Interface; //Interface(arayüz) tanımlama--üst derece sınıf.

class Program
{
    static void Main(string[] args)
    {
        IRepo repo = new ProductRepo(); 
    }
}
