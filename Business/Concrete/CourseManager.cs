using Business.Abstract;
using Business.Constance;
using Core.Helpers.Results.Abstract;
using Core.Helpers.Results.Concrete.ErrorResult;
using Core.Helpers.Results.Concrete.SuccessResult;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CourseManager : ICourseServices
    {
        private readonly ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public IResult Add(Course course)
        {
            try
            {
                _courseDal.Add(course);
                return new SuccessResult(Message.CoursesAdd);

            }
            catch (Exception error)
            {

                return new ErrorResult(error.Message);
            }
           
        }
    }
}
