using Business.Abstract;
using Business.Constance;
using Core.Helpers.Results.Abstract;
using Core.Helpers.Results.Concrete.ErrorResult;
using Core.Helpers.Results.Concrete.SuccessResult;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOS;
using MongoDB.Bson;
using MongoDB.Driver.Core.Operations;
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

        public IResult Delete(int courseId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Course>> GetAll()
        {
            try
            {

                var course=_courseDal.GetAll();
                return new SuccessDataResult<List<Course>>(course);
            }
            catch (Exception)
            {

                return new ErrorDataResult<List<Course>>(Message.CourseListNotFound);
            }
        }

        public IDataResult<List<CourseContentDTO>> GetByCourseId()
        {
            try
            {
                var coursecontent = _courseDal.GetCourseContent();
                return new SuccessDataResult<List<CourseContentDTO>>(coursecontent);

            }
            catch (Exception e)
            {

                return new ErrorDataResult<List<CourseContentDTO>>(e.Message);
            }
        }

        public IDataResult<Course> GetById(string id)
        {
            try
            {
                var course = _courseDal.Get(x => x._id == id);
                return new SuccessDataResult<Course>(course);

            }
            catch (Exception)
            {

                return new ErrorDataResult<Course>(Message.CourseNotFound);
            }
        }

        public IResult Update(int courseId)
        {
            throw new NotImplementedException();
        }
    }
}
