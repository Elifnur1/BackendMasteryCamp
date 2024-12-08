// Bir e-ticaret sistemimiz var. Ürünlerin farklı tipleri olabilir,elektronik , giyim, gıda...Her ürünün temel özellikleri aynı iken ,bazı özellikleri tipe göre değişiklik gösterebilir.Bu durumda üst sınıf olarak planlayacağımız Product bir abstract class olacaktır.


Electronic electronic1 = new()
{
    Id = 1,
    Name = "Müzik Çalar",
    Price = 580

};
decimal discount1 = electronic1.CalculateDiscountedPrice();
System.Console.WriteLine(discount1);


Electronic Clothing = new()
{
    Id = 2,
    Name = "erkek kot pantolon",
    Price = 600

};
decimal discount2 = Clothing.CalculateDiscountedPrice();
System.Console.WriteLine(discount2);

interface IProduct
{

    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public abstract decimal CalculateDiscountedPrice();
}

class Clothing : IProduct
{


    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }

    public decimal CalculateDiscountedPrice()
    {
        double result = (double)Price * 0.2 + 1;
        return Convert.ToDecimal(result);
    }
}

class Electronic : IProduct
{
    public int Id
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }
    public string? Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public decimal Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public decimal CalculateDiscountedPrice()
    {
        double result = (double)Price * 0.1;
        return Convert.ToDecimal(result);


    }

}





// abstract class Product{
//     public int Id { get; set; }
//     public string? Name { get; set; }
//     public decimal Price { get; set; }
//     public abstract decimal CalculateDiscountedPrice();
// }

// class Electronic:Product
// {
//     public int warrantyPeriod { get; set; }

//     public override decimal CalculateDiscountedPrice()
//     {
//         throw new NotImplementedException();
//     }
// }

// class Clothing:Product{
//     public string? Size { get; set; }

//     public override decimal CalculateDiscountedPrice()
//     {
//         throw new NotImplementedException();
//     }
// }