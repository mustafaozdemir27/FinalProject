using Core.Entities;
using System.Linq.Expressions;

//Core katmanlari diger katmanlari referans almaz
namespace Core.DataAccess
{
    // generic constraint
    // class : referans tip
    // IEntity : IEntity  olabilir veya IEntity implemente eden bir nesnede olabilir
    // new() : new'lenebilir olmali (Soyut nesneler(Interfaceler) newlenemez) 
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>>? filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
