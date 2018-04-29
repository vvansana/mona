using Mona.Webapi.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SharedKernel.Data.Repository
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> All();
        IEnumerable<Category> AllInclude(params Expression<Func<Category, object>>[] includeProperties);
        void Delete(int id);
        IEnumerable<Category> FindByInclude(Expression<Func<Category, bool>> predicate,
            params Expression<Func<Category, object>>[] includeProoperties);
        Category FindByKey(int id);
        void Insert(Category domainObject);
        void Update(Category domainObject);

    }
}