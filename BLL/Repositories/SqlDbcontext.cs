using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class SqlDbcontext<T>:SqlDbcontext where T:BaseEntity
    {
        public DbSet<T> Entities { get; set; }
    }
    


   public  class SqlDbcontext:DbContext
    {
        public SqlDbcontext():base ("19bang")
        {
            Database.Log = s => Debug.WriteLine(s);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {


            modelBuilder.Entity<User>();
            modelBuilder.Entity<Article>();//建表
            base.OnModelCreating(modelBuilder);

        }
        ///  public DbSet <Student> Students { get; set; }

    }  

   
}
