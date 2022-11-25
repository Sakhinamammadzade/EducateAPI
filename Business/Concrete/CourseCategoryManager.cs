using Business.Abstract;
using Business.Constance;
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
    public class CourseCategoryManager : ICourseCategoryManager
    {
        private readonly ICourseCategoryDal courseCategoryDal;

        public CourseCategoryManager(ICourseCategoryDal courseCategoryDal)
        {
            this.courseCategoryDal = courseCategoryDal;
        }

        public IResult Add(CourseCategory courseCategory)
        {
            try
            {
                this.courseCategoryDal.Add(courseCategory);
                return new SuccessResult(Message.CourseCategoryAdded);
            }
            catch (Exception)
            {

                return new ErrorResult(Message.CourseCategoryNotFound);
            }
        }

        public IDataResult<List<CourseCategoryDTO>> GetcourseCategory()
        {
            try
            {
                var courseCategory = courseCategoryDal.GetContentCategories();
                return new SuccessDataResult<List<CourseCategoryDTO>>(courseCategory);
            }
            catch (Exception e)
            {

                return new ErrorDataResult<List<CourseCategoryDTO>>(e.Message);
            }
        }

       

        public IResult Remove(int Id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(int Id)
        {
            throw new NotImplementedException();
        }

       
       

        IDataResult<CourseCategory> ICourseCategoryManager.GetById(string id)
        {
            try
            {
                var courseCategory = courseCategoryDal.Get(x => x._id == id);
                return new SuccessDataResult<CourseCategory>(courseCategory);
            }
            catch (Exception)
            {

                return new ErrorDataResult<CourseCategory>(Message.CourseCategoryNotFound);
            }
        }
    }
}
