using MVP.Core.Entities;
using MVP.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Infrastructure.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
    }
}
