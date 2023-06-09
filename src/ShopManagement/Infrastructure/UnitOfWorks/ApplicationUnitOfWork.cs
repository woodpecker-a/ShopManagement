﻿using Infrastructure.DbContexts;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.UnitOfWorks
{
    public class ApplicationUnitOfWork : UnitOfWork, IApplicationUnitOfWork
    {
        public IProductRepository Products { get; private set; }

        public ApplicationUnitOfWork(IApplicationDbContext db, IProductRepository product) : base((DbContext)db)
        {
            Products = product;
        }
    }
}
