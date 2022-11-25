using Business.Concrete;
using Core.Helpers.Results.Abstract;
using Entities.Concrete;
using Entities.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICourseCategoryManager
    {
        IResult  Add(CourseCategory courseCategory);
        IResult Remove(int Id);
        IResult Update(int Id);
        IDataResult<List<CourseCategoryDTO>> GetcourseCategory();
        IDataResult<CourseCategory> GetById(string id);

    }
}
