using Core.Helpers.Results.Abstract;
using Entities.Concrete;
using Entities.DTOS;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICourseServices
    {
        IResult Add(Course course);
        IResult Update(int courseId);
        IResult Delete(int courseId);
        IDataResult<List<Course>> GetAll();
        IDataResult<Course> GetById(string id);
        IDataResult<List<CourseContentDTO>> GetByCourseId();

    }
}
