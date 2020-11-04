using Core.CoreDataAccess;
using Core.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.EntityFramework
{
    /*Aşşagıda bira base oluşturduk  contexi ve datayı alan 
     Ve diger interfaceden metodları implemente edicez metodları solid prensiplerine baglı kalıyoruz*/
    public class EfEntityRepostoryBase<Tentiy, TContext> : IEntityRepostory<Tentiy>
        where Tentiy : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(Tentiy entity)
        {
           using(var  context=new TContext())
            {
                var addedEntity= context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Tentiy entity)
        {
            using (var context = new TContext())
            {
                var deleteEntity = context.Entry(entity);
                deleteEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public IList<Tentiy> GetList(Expression<Func<Tentiy, bool>> filter )
        {
            using (var context = new TContext())
            {
                if (filter != null)
                {
                    return context.Set<Tentiy>().Where(filter).ToList();//İf koşulu
                }
                else
                {
                    return context.Set<Tentiy>().ToList();
                }

            }
        }

        public Tentiy GetT(Expression<Func<Tentiy, bool>> filter)
        {
          using(var context =new TContext())
            {
                return context.Set<Tentiy>().SingleOrDefault(filter);
            }
        }

        public void Update(Tentiy entity)
        {
            using (var context = new TContext())
            {
                var modifiedEntity = context.Entry(entity);
                modifiedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
