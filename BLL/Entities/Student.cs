using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public Student InvitedBy { get; set; }

        public void Register()
        {
            throw new NotImplementedException();
        }
    }
}
