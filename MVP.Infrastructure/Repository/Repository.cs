using MVP.Core.Entities;
using MVP.Core.Interfaces;
using MVP.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Infrastructure.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly MvpDbContext _context;

        public Repository()
        {
            _context = new MvpDbContext();
        }

        public Repository(MvpDbContext context)
        {
            _context = context;
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public T GetSingle(ISpecification<T> specification)
        {
            return Get(specification).FirstOrDefault();
        }

        public IEnumerable<T> Get(ISpecification<T> specification)
        {
            var queryWithInclude = specification.Includes.Aggregate(_context.Set<T>().AsQueryable(), (current, include) => current.Include(include));

            var query = specification.IncludeStrings.Aggregate(queryWithInclude, (current, include) => current.Include(include));

            return query.Where(specification.Filter).AsEnumerable();
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();

            return entity;
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }
    }
}
