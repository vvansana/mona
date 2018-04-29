using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ReusableGenericRepository
{
    public static class Utilities
    {
        public static Expression<Func<TEntity,bool>> BuildLambdaForFindByKey<TEntity>(int id)
        {
            //item is the type being queried so it's creating a paramenter called entity with the value of typeof(TEntity)
            var item = Expression.Parameter(typeof(TEntity), "entity");

            //string representation of the the property name
            var prop = Expression.Property(item, typeof(TEntity).Name.Replace("Entity","") + "Id");
            //the variable we are comparing the property to
            var value = Expression.Constant(id);
            //evaluate by making sure prop and value are equal (Expression.GreaterThan would check greater than etc)
            var equal = Expression.Equal(prop, value);

            var lambda = Expression.Lambda<Func<TEntity, bool>>(equal, item);

            return lambda;
        }
    }
}
