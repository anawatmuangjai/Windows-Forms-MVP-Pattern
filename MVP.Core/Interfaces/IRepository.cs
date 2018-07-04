using MVP.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Core.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        T GetById(int id);
        T GetSingle(ISpecification<T> specification);
        IEnumerable<T> GetAll();
        IEnumerable<T> Get(ISpecification<T> specification);
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
