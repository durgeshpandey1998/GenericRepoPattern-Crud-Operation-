using GenericRepoPattern.Data;
using Microsoft.EntityFrameworkCore;

namespace GenericRepoPattern.GenericRepository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context = null;
        private DbSet<T> table = null;
        public Repository(ApplicationDbContext context)
        {
            this._context = context;
            table = _context.Set<T>();
    }
        public void Delete(T Id)
        {
            table.Remove(Id);
            _context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(object Id)
        {
            return table.Find(Id);
        }

        public void Insert(T obj)
        {
             table.Add(obj);
            _context.SaveChanges();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public T Update(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
