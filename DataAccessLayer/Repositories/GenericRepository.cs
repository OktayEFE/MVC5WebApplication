using DataAccessLayer.Abstract;
using DataAccessLayer.Connection;
using System.Data.Entity;

namespace DataAccessLayer.Repositories
{
    public  class GenericRepository<T> : IGenericDal<T> where T : class
    {
        AppContext _context = new AppContext();
        DbSet<T> _object;

        public GenericRepository()
        {
            _object = _context.Set<T>();
        }

        public void Insert(T entity)
        {
           _object.Add(entity);
            _context.SaveChanges();
        }
    }
}
