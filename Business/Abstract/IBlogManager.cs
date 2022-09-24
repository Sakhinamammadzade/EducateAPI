using Core.Helpers.Results.Abstract;
using Core.Helpers.Results.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBlogManager
    {
        IResult Add(Blog blog);
        IResult Remove(int id);
        IResult Update(Blog blog);  
        IDataResult <List<Blog>> GetAll();  
        IDataResult <Blog> GetById(int id);  
    }
}
