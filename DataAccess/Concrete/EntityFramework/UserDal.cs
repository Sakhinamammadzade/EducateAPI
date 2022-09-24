using Core.DataAccess.EntitiyFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.DTOS;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class UserDal : EfRepositoryBase<User, AppDbContext>, IUserDal
    {
        public List<UserListDTO> GetAllUsers()
        {
            using (var _context = new AppDbContext())
            {
                List<UserListDTO> users = _context.Users.Select(x => new UserListDTO
                {
                    Id = x.Id,
                    Name = x.Name,
                    Surname = x.SurName,
                    Email = x.Email,
                }).ToList();

                return users;
            }
         }
    }
}
