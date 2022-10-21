using Microsoft.EntityFrameworkCore;
using std_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace std_Management
{
    public class RepositoryBase<T> where T : class
    {
        private readonly Std_ManagementContext _context;
        private readonly DbSet<T> _dbSet;
        public RepositoryBase()
        {
            _context = new Std_ManagementContext();
            _dbSet = _context.Set<T>();
        }

        public T Get(String id)
        {
            return _dbSet.FirstOrDefault();
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Create(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            var tracker = _context.Attach(entity);
            tracker.State = EntityState.Modified;
            //_dbSet.Update(entity);
            _context.SaveChanges();
        }
    }
}
