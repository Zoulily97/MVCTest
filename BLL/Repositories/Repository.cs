using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Entities;


namespace BLL.Repositories
{
    public class Repository<T>where T:BaseEntity
    {
        protected SqlDbcontext<T> context;
        public Repository()
        {
            //context = new SqlDbcontext<T>(); ??
        }
        public void Save(T entity)
        {
            context.Entities.Add(entity);
            context.SaveChanges();
           // return entity.Id;

        }
        public void Remove(T entity) 
        {
            context.Entities.Remove(entity);
        }

    }
    
}
