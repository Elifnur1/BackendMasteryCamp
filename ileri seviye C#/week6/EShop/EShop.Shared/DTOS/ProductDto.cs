using System;

namespace EShop.Shared.DTOS;

public class ProductDto
{
    public int Id { get; set; }
    public DateTime UpdatedDate { get; set; }
    public bool IsActive { get; set; } = true;
    public bool IsDeleted { get; set; }
    public string? Name { get; set; }
    public string? Properties { get; set; }
    public decimal Price { get; set; }
    public string ImageUrl { get; set; } = string.Empty;
    public ICollection<CategoryDto> Categories { get; set; } = new List<CategoryDto>();
}
