using Business.Abstract;
using Business.Constance;
using Core.Entities.Concrete;
using Core.Helpers.Results.Abstract;
using Core.Helpers.Results.Concrete.ErrorResult;
using Core.Helpers.Results.Concrete.SuccessResult;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserManager
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void AddUser(User user)
        {
            _userDal.Add(user);
        }

        public IDataResult<List<UserListDTO>>GetAllUsers()
        {
            var users= _userDal.GetAllUsers();
            return new SuccessDataResult<List<UserListDTO>>(users);

        }

        public User GetUser(string email)
        {
            return _userDal.Get(x => x.Email == email);
        }

        public IDataResult<UserListDTO> GetUsersById(string email)
        {
            var user = _userDal.Get(x => x.Email == email);
            if (user == null)
            {
                return new ErrorDataResult<UserListDTO>(Message.UserNotFound);

            }
            UserListDTO result = new()
            {
                Id=user.Id,
                Name=user.Name,
                Email=user.Email,
                Surname=user.SurName

            };
            return new SuccessDataResult<UserListDTO>(result);


        }

        public void RemoveUser(User user)
        {
            _userDal.Delete(user);
        }

        public void UpdateUser(User user)
        {
            _userDal.Update(user);
        }

     
    }
}

