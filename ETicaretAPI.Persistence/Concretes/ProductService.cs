using ETicaret.Domain.Entities;
using ETicaretAPI.Application.Abstractions;

namespace ETicaretAPI.Persistence.Concretes;

public class ProductService:IProductService
{
    public List<Product> GetProducts() => new()
    {
        new(){Id = Guid.NewGuid(),Name = "Product1",Price = 20, Stock = 30},
        new(){Id = Guid.NewGuid(),Name = "Product2",Price = 10, Stock = 40},
        new(){Id = Guid.NewGuid(),Name = "Product3",Price = 30, Stock = 50},
        new(){Id = Guid.NewGuid(),Name = "Product4",Price = 40, Stock = 60}

    };

}