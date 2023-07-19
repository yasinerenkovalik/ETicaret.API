using ETicaret.Domain.Entities.Commen;

namespace ETicaret.Domain.Entities;

public class Order:BaseEntity
{
    public int CustomerId { get; set; }
    public string Description { get; set; }
    public string Address { get; set; }
    public ICollection<Order> Orders { get; set; }
    public Customer Customer { get; set; }
}