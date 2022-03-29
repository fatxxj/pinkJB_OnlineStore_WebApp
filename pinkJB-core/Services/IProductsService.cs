﻿using pinkJB_core.Data.Base;
using pinkJB_core.Models;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace pinkJB_core.Services
{
    public interface IProductsService : IEntityBaseRepository<Product>
    {
        Task<Product> getProductByIdAsync(int id);
        Task<Product> getProductByNameAsync(string name);
        //Task<Product> GetAllAsync(params Expression<Func<T, object>>[] includeProperties);
    }
}
