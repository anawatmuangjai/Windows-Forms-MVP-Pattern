using MVP.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Core.Interfaces
{
    public interface IUserRepository
    {
        UserDto GetUser(string username);
    }
}
