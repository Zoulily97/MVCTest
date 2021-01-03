using BLL;
using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
   public class StudentRepository
    {

        //public Student GetByName(string name)
        //{
        //    SqlDbcontext context = new SqlDbcontext();
        //    return context.Students.Where (s=>s.Name==name).SingleOrDefault();
        //}

        public int Save(Student student)
        {
            throw new NotImplementedException();
        }

        public object GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
