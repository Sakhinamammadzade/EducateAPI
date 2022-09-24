using Core.Entities.Concrete;
using Core.Helpers.Results.Abstract;
using Entities.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAuthManager
    {
        IDataResult<User> Register(RegisterDTO registerdDTO);
        IDataResult<User> Login(LoginDTO loginDto);
    }
}
