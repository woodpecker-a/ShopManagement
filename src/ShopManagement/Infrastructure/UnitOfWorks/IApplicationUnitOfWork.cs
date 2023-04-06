using Infrastructure.Repositories;

namespace Infrastructure.UnitOfWorks
{
    public interface IApplicationUnitOfWork
    {
        IProductRepository Product { get; }
    }
}