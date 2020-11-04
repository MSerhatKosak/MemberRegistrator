using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.CoreDataAccess
{
    /*Aşagıda generic olarak çalışıyoruz çünkü eklemek istedigimiz verileri tek tek yazmak yerine
     birkez yazıp kullanıcagız kullandıgımız yer ise 
    DataAccess*/
    public interface IEntityRepostory<T> where T : class, IEntity, new()
    {
        //Expression gönderiyoruz yani parametre de alabilir 
        T GetT(Expression<Func<T, bool>> filter);
        IList<T> GetList(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
