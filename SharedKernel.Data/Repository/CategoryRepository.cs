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
    public class CategoryRepository : ICategoryRepository
    {
        private GenericRepository<CategoryEntity> _genericRepository = null;
        private IMapper _mapper;
        public CategoryRepository(GenericRepository<CategoryEntity> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;

        }

        public void Insert(Category domainObject)
        {
           
            var entity = _mapper.Map<CategoryEntity>(domainObject);
            _genericRepository.Insert(entity);
        }

        public Category FindByKey(int id)
        {
            var entity = _genericRepository.FindBy(x => x.CategoryId == id).FirstOrDefault();
            _mapper.Map<Category>(entity);
            return _mapper.Map<Category>(entity);
        }

        public IEnumerable<Category> All()
        {
            var productEntities = _genericRepository.All();
            return _mapper.Map<IEnumerable<Category>>(productEntities);
        }

        public IEnumerable<Category> AllInclude(params Expression<Func<Category, object>>[] includeProperties)
        {
            
            var convertedIncludeProperties = _mapper.Map<Expression<Func<CategoryEntity, object>>[]>(includeProperties);
            var productEntities = _genericRepository.AllInclude(convertedIncludeProperties);
            return _mapper.Map<IEnumerable<Category>>(productEntities);
        }

        public void Delete(int id)
        {
            _genericRepository.Delete(id);
        }

        public IEnumerable<Category> FindByInclude(Expression<Func<Category, bool>> predicate, params Expression<Func<Category, object>>[] includeProperties)
        {
            var convertedPredicate = _mapper.Map<Expression<Func<CategoryEntity, bool>>>(predicate);
            var convertedIncludeProperties = _mapper.Map<Expression<Func<CategoryEntity, object>>[]>(includeProperties);
            var result = _genericRepository.FindByInclude(convertedPredicate, convertedIncludeProperties);
            var convertedResults = _mapper.Map<IEnumerable<Category>>(result);
            return convertedResults;
        }

        public void Update(Category domainObject)
        {
            var entity =  _mapper.Map<CategoryEntity>(domainObject);
            _genericRepository.Update(entity);
        }
    }
}
