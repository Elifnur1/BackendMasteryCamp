using System;
using EShop.Entity.Abstract;
using EShop.Shared.ComplexTypes;

namespace EShop.Entity.Concrete;

public class Order:BaseEntity
{
    private Order()
    {
    }
    public Order(string? applicationUserId, string? adress, string? city)
    {
        ApplicationUserId = applicationUserId;
        Adress = adress;
        City = city;
    }

    public string? ApplicationUserId { get; set; }
    public ApplicationUser? ApplicationUser { get; set; }
    public string? Adress { get; set; }
    public string? City { get; set; }
    public OrderStatusType? OrderStatusType { get; set; }
    public ICollection<OrderItem> OrderItems { get; set; }=new List<OrderItem>();
}
