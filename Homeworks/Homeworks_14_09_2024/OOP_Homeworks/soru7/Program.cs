namespace soru7;

public class Product
{
    public Product(string name, double price, int stokMiktarı)
    {
        Name = name;
        Price = price;
        StokMiktarı = stokMiktarı;
    }

    public string Name { get; set; }
    public double Price { get; set; }
    public int StokMiktarı { get; set; }
    public bool CheckStock(int miktar)
    {
        return StokMiktarı>=miktar;
    }
    public void UpdateStock(int miktar)
    {
        StokMiktarı+=miktar;
    }
    public virtual void BilgileriEkranaYaz()
    {
        System.Console.WriteLine($"{Name} : ürün adı\n{Price} : ürünün fiyatı\n{StokMiktarı} : stok miktarı ");
    }

}
public class FoodProduct : Product
{
    public FoodProduct(string name, double price, int stokMiktarı, DateTime expirationDate) : base(name, price, stokMiktarı)
    {
        ExpirationDate = expirationDate;
    }
    public DateTime ExpirationDate { get; set; }
    public override void BilgileriEkranaYaz()
    {
        base.BilgileriEkranaYaz();
        System.Console.WriteLine($"Son kullanma tarihi: {DateTime.Now}");
    }
}
class ElectronicProduct : Product
{
    public ElectronicProduct(string name, double price, int stokMiktarı, bool sarjetme) : base(name, price, stokMiktarı)
    {
        this.sarjetme = sarjetme;
    }
    public bool sarjetme { get; set; }
    public override void BilgileriEkranaYaz()
    {
        base.BilgileriEkranaYaz();
        System.Console.WriteLine($"şarjlı:{sarjetme}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Product product1=new Product("Apple",45000,200);
        product1.BilgileriEkranaYaz();
        product1.CheckStock(50);
        product1.UpdateStock(30);

        FoodProduct foodProduct1=new FoodProduct("Elma",50,1000,DateTime.Now);
        foodProduct1.BilgileriEkranaYaz();
        ElectronicProduct electronicProduct1=new ElectronicProduct("MacOs",50000,30,true);
        electronicProduct1.BilgileriEkranaYaz();
    }
}
