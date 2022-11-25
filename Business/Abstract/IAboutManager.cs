using Core.Helpers.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAboutManager
    {
        IResult Add(About about);
        IResult Remove(string id);
        IResult Update(string id);
        IDataResult <List<About>> GetAll();
        IDataResult <About>GetById(string id);

    }
}
