using System;

namespace EShop.Shared.DTOS;

public class CartItemDto
{
    public int Id { get; set; }
    public int CartId { get; set; }
    public int ProductId { get; set; }
    public ProductDto Product { get; set; }=new ProductDto();
    public int Quantity { get; set; }
}
