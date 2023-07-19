using System.Security.Cryptography;
using ETicaret.Domain.Entities.Commen;

namespace ETicaret.Domain.Entities;

public class Product:BaseEntity
{
    public string Name { get; set; }
    public int Stock { get; set; }
    public long Price { get; set; }
}