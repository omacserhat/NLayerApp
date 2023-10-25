using System.Linq.Expressions;

namespace NLayer.Core.Repositories
{
    //Veritabanına yapacağımız tüm temel sorgular bu kısımda yer alıyor.
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        IQueryable<T> GetAll();
        // productRepository.where(x=>x.id > 5).OrderBy.ToListAsync();   orderby ekleyebilmek için yapıyoruz.
        //.ToList eklendiği anda dönüş sağlar.
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}