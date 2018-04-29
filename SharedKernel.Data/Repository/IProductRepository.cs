using Mona.Webapi.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SharedKernel.Data.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> All();
        IEnumerable<Product> AllInclude(params Expression<Func<Product, object>>[] includeProperties);
        void Delete(int id);
        IEnumerable<Product> FindByInclude(Expression<Func<Product, bool>> predicate,
            params Expression<Func<Product, object>>[] includeProoperties);
        Product FindByKey(int id);
        void Insert(Product domainObject);
        void Update(Product domainObject);

    }
}