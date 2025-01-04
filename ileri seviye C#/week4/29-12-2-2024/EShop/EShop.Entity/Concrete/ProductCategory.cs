using System;

namespace EShop.Entity.Concrete;

public class ProductCategory
{
    private ProductCategory() 
    {
        
    }
    public int ProductId { get; set; }

    public ProductCategory(int productId, int categoryId)
    {
        ProductId = productId;
        CategoryId = categoryId;
    }

    public Product? Product { get; set; }
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
}
