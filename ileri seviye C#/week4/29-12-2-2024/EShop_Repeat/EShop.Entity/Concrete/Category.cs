using System;
using EShop.Entity.Abstract;

namespace EShop.Entity.Concrete;

public class Category : BaseEntity
{
    private Category()
    {

    }
    public Category(string name, string ımageUrl)
    {
        Name = name;
        ImageUrl = ımageUrl;
    }

    public string Name { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public string Description { get; set; }
    public ICollection<ProductCategory> ProductCategories { get; set; } = new HashSet<ProductCategory>();
}
