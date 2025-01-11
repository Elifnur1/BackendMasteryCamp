using System;
using EShop.Shared.ComplexTypes;

namespace EShop.Shared.DTOS;

public class OrderDto
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public string? ApplicationUserId { get; set; }
    public ApllicationUserDto ApllicationUser { get; set; } = new ApllicationUserDto();
    public string? Address { get; set; }
    public string? City { get; set; }
    public OrderStatusType OrderStatus { get; set; }
    public ICollection<OrderItemDto> OrderItems { get; set; } = new List<OrderItemDto>();
    public decimal TotalAmount => OrderItems.Sum(x => x.Product.Price * x.Quantity);
}
