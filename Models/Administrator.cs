using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTe.Models
{
    public class Administrator : User
    {
        public Administrator() { }
        public Administrator(User person)
        {
            FirstName = person.FirstName;
            LastName = person.LastName;
            Username = person.Username;
            Password = person.Password;
            UserStatus = person.UserStatus;
        }
    }
}
