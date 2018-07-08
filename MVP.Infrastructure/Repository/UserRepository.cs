using AutoMapper;
using MVP.Core.Dtos;
using MVP.Core.Entities;
using MVP.Core.Interfaces;
using MVP.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IMapper _mapper;

        private readonly MvpDbContext _context;

        public UserRepository(IMapper mapper, MvpDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public UserDto GetUser(string username)
        {
            var user = _context.Users.FirstOrDefault(x => x.Username == username);

            return _mapper.Map<UserDto>(user);
        }
        //public UserRepository(MvpDbContext context)
        //{
        //    _context = context;
        //}

        //public UserDto GetUser(string username)
        //{
        //    var user = _context.Users.FirstOrDefault(x => x.Username == username);
        //
        //    var userDto = new UserDto
        //    {
        //        Id = user.Id,
        //        Username = user.Username,
        //        Password = user.Password,
        //        Firstname = user.Firstname,
        //        Lastname = user.Lastname
        //    };
        //
        //    return userDto;
        //}
    }
}
