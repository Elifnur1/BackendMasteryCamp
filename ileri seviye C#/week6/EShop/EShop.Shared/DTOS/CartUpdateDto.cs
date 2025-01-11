using System;

namespace EShop.Shared.DTOS;

public class CartUpdateDto
{
    public int Id { get; set; }
    public bool IsActive { get; set; }
    public bool IsDeleted { get; set; }
}
