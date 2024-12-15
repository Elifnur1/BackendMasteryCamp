using System;
using EFCore.Entity.Abstract;

namespace EFCore.Entity.Concrete;

public class Category:BaseEntity
{
    public string? Description { get; set; }
    public IEnumerable<Product>? products {get; set;}=[];
}
