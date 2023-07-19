using ETicaret.Domain.Entities.Commen;

namespace ETicaret.Domain.Entities;

public class Customer:BaseEntity
{
    public ICollection<Order> Orders { get; set; }
    public string Name { get; set; }
}