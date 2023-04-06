using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DbContexts
{
    public interface IApplicationDbContext
    {
        DbSet<Product> Products { get; set; }
    }
}