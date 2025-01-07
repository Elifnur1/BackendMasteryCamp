using System;

namespace EShop.Entity.Abstract;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow; //UTC zamanının genel kabul gördüğü bir durumdur.Yani tüm dünyada aynıdır.
    public bool IsActive { get; set; } = true;
    public bool IsDeleted { get; set; }

}
