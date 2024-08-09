using Aranoz.Application.Interfaces;
using Aranoz.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Persistance.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AranozContext _context;

        public Repository(AranozContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> CreateAsync(T entity)
        {
            await Table.AddAsync(entity);

            // kayıt başarılı ise 1 döner başarısız ise 1
            if (await _context.SaveChangesAsync() > 0) return true;

            else return false;

        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await Table.FindAsync(id);
            Table.Remove(entity);

            if (await _context.SaveChangesAsync() > 0) return true;

            else return false;

        }

        public async Task<bool> UpdateAsync(T entity)
        {
            Table.Update(entity);

            if (await _context.SaveChangesAsync() > 0) return true;

            else return false;
        }


        // AsNoTracking verileri izlemeden getirir. Performans artışı sağlar.
        // tek bir satırda yazdığım için => işareti ile yazdım parantezleri kaldırdım.
        //GetAllAsync filter, include filter var ise ve include var ise kullanılır.
        public async Task<List<T>?> GetAllAsync() => await Table.AsNoTracking().ToListAsync();

        public async Task<List<T>?> GetAllAsync(Expression<Func<T, bool>>? filter=null, params Expression<Func<T, object>>[]? includes) 
        {
            IQueryable<T> values = Table;
            if(filter != null)
            {
                values = values.Where(filter);
            }
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    values = values.Include(include);
                }
            }
                

            return await values.AsNoTracking().ToListAsync(); 
          }

        public async Task<int> GetCountAsync() =>await Table.CountAsync();

        public async Task<int> GetCountAsync(Expression<Func<T, bool>> filter) => await Table.Where(filter).CountAsync();

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> filter) => await Table.FirstOrDefaultAsync(filter);

        public async Task<int> SaveChanges() => await _context.SaveChangesAsync();

        public async Task<T> GetSingleByIdAsync(int id) => await Table.FindAsync(id);

        
    }
}
