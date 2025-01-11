using System;

namespace EShop.Shared.DTOS;

public class CartDto
{
    public int Id { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public bool IsActive { get; set; }
    public bool IsDeleted { get; set; }
    public string? ApplicationUserId { get; set; }
    public ApllicationUserDto ApplicationUser { get; set; } = new ApllicationUserDto();
    public ICollection<CartItemDto> CartItems { get; set; } = new List<CartItemDto>();

    // public decimal TotalPrice() => CartItems.Sum(x => x.Product.Price * x.Quantity); //Bu aynı hesaplamanın Method haliyle yazılmıştır.

    public decimal TotalAmount => CartItems.Sum(x => x.Product.Price * x.Quantity);  //Bu sadece alınan ürünün toplam adediyle birlikte fiyatın çarpılmış sonucu yazılı.Bir property olarak yazdık

    public int TotalItems => CartItems == null ? 0 : CartItems.Count();
}


