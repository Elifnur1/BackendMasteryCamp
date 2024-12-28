using System;

namespace EFCore.Shared.Dtos;

public class ProductCreateDto
{
   public string? Name { get; set; }
   public string? Properties { get; set; }
   public decimal Price { get; set; }
   public int[] CategoryId { get; set; }
   
}
