using HR_Management.Application.Persistence.Contracts;
using HR_Managment.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Managment.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly LeaveManagmentContext _context;

        public GenericRepository(LeaveManagmentContext context)
        {
            _context = context;
        }

        public async Task<T> Add(T entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<T> Get(int id)
        {
            var TEntity= await _context.Set<T>().FindAsync(id);
           
            return TEntity;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
          return await _context.Set<T>().ToListAsync();
        }

        public async Task Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
