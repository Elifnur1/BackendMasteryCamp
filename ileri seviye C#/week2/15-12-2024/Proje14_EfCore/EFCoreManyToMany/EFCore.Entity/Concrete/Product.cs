using System;
using EFCore.Entity.Abstract;

namespace EFCore.Entity.Concrete;

public class Product : BaseEntity
{
    public string? Properties { get; set; }
    public decimal Price { get; set; }
    public bool IsThere { get; set; }
   
}

