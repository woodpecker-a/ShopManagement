using Infrastructure.Repositories;

namespace Infrastructure.UnitOfWorks
{
    public interface IApplicationUnitOfWork : IUnitOfWork
    {
        IProductRepository Products { get; }
    }
}