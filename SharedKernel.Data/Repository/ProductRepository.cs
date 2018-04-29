using AutoMapper;
using DisconnectedGenericRepository;
using Mona.Webapi.Models;
using SharedKernelData.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;

namespace SharedKernel.Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        private GenericRepository<ProductEntity> _genericRepository = null;
        private IMapper _mapper;
        public ProductRepository(GenericRepository<ProductEntity> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;

        }

        public void Insert(Product domainObject)
        {
            
            var entity = _mapper.Map<ProductEntity>(domainObject);
         
            _genericRepository.Insert(entity);
        }

        public Product FindByKey(int id)
        {
            var entity = _genericRepository.FindBy(x => x.ProductId == id).FirstOrDefault();
            _mapper.Map<Product>(entity);
            return _mapper.Map<Product>(entity);
        }

        public IEnumerable<Product> All()
        {
            var productEntities = _genericRepository.All();
            return _mapper.Map<IEnumerable<Product>>(productEntities);
        }

        public IEnumerable<Product> AllInclude(params Expression<Func<Product, object>>[] includeProperties)
        {
            
            var convertedIncludeProperties = _mapper.Map<Expression<Func<ProductEntity, object>>[]>(includeProperties);
            var productEntities = _genericRepository.AllInclude(convertedIncludeProperties);
            return _mapper.Map<IEnumerable<Product>>(productEntities);
        }

        public void Delete(int id)
        {
            _genericRepository.Delete(id);
        }

        public IEnumerable<Product> FindByInclude(Expression<Func<Product, bool>> predicate, params Expression<Func<Product, object>>[] includeProperties)
        {
            var convertedPredicate = _mapper.Map<Expression<Func<ProductEntity, bool>>>(predicate);
            var convertedIncludeProperties = _mapper.Map<Expression<Func<ProductEntity, object>>[]>(includeProperties);
            var result = _genericRepository.FindByInclude(convertedPredicate, convertedIncludeProperties);
            var convertedResults = _mapper.Map<IEnumerable<Product>>(result);
            return convertedResults;
        }

        public void Update(Product domainObject)
        {
            var entity =  _mapper.Map<ProductEntity>(domainObject);
            _genericRepository.Update(entity);
        }
    }
}
