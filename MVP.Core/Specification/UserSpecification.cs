using MVP.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Core.Specification
{
    public class UserSpecification : BaseSpecification<User>
    {
        public UserSpecification(string username) 
            : base(u => u.Username == username)
        {
        }
    }
}
