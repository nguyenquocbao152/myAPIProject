using Microsoft.EntityFrameworkCore;
using myAPIProject.IRepository;
using myAPIProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace myAPIProject.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DatabaseContext _context;
        private readonly DbSet<T> _db;
        public Task<T> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public Task<T> Get(Expression<Func<T, bool>> expression = null, List<string> includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<IList<T>> GetAll(Expression<Func<T, bool>> expression = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, List<string> includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<T> Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> InsertRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
