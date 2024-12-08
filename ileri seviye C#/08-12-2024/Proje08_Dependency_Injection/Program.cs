abstract class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public abstract decimal CalculateDiscount();
}
class Electronic : Product
{
    public int period { get; set; }

    public override decimal CalculateDiscount()
    {
        throw new NotImplementedException();
    }
}

class Food : Product
{
    public DateTime ExpirationDate { get; set; }
    public override decimal CalculateDiscount()
    {
        throw new NotImplementedException();
    }


}

interface IProductRepository
{
    Product GetProductById(int id);
    List<Product> GetAll();
}


class ProductRepository : IProductRepository
{
    public List<Product> GetAll()
    {
        throw new NotImplementedException();
    }

    Product GetProductById(int id)
    {
        return new Electronic { Id = id, Name = "Iphone", period = 5 };
    }

    Product IProductRepository.GetProductById(int id)
    {
        throw new NotImplementedException();
    }
}

class OrderService
{
    private readonly IProductRepository _productRepository;
    public OrderService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }


    public void ProcessOrder(int id)
    {
        // ProductRepository productRepository=new ProductRepository();
        var product = _productRepository.GetProductById(id);
        //Burada order ile ilgili işlemler yapılıyor...
    }
}
