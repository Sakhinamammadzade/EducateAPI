using Core.Helpers.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IChooseManager
    {
        IResult Add(ChooseCourse choose);
        IDataResult<ChooseCourse>GetById(int id);
     
    }
}
