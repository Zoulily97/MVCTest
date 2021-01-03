using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class User:BaseEntity 
    {    
        public string Name { get; set; }
        public string Password { get; set; }
        public User InvitedBy { get; set; }
        public void Register() 
        {
            throw new NotImplementedException("");
        }
    }
}
