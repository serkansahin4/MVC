using ChatAppDeneme.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ChatAppDeneme.DataAccess.Abstract
{
    public interface IRepositoryBase<T> where T:BaseEntity
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        List<T> GetAll(string lazyPath,Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T,bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
