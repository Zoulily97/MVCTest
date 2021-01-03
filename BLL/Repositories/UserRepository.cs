using BLL;
using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
   public class UserRepository:Repository<User >
    {
        public UserRepository()
        {
            context = new SqlDbcontext<User>();//实例化context 
        }
        public User GetByName(string name)
        {

            return context.Entities.Where(s => s.Name == name).SingleOrDefault();
        }

      
    }
}
