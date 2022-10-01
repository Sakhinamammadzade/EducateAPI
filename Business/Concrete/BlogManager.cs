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
    public class BlogManager : IBlogManager
    {
        private readonly IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public IResult Add(Blog blog)
        {
            try
            {
                _blogDal.Add(blog);
                return new SuccessResult(Message.CoursesAdd);

            }
            catch (Exception)
            {
                return new ErrorResult(Message.ChooseNotAdded);
            }
          
           
        }

        public IDataResult<List<Blog>> GetAll()
        {
            try
            {
                var blog = _blogDal.GetAll(x => x.IsDelete == false);
                return new SuccessDataResult<List<Blog>>(blog);
            }
            catch (Exception)
            {

                     return new ErrorDataResult<List<Blog>>();
            }
        }

        public IDataResult<Blog> GetById(int id)
        {
            try
            {
                var blog = _blogDal.Get(x => x.Id == id);
                return new SuccessDataResult<Blog>(blog);
            }
            catch (Exception)
            {

                return new ErrorDataResult<Blog>();
            }
        }

        public IResult Remove(int id)
        {
            try
            {
                var blog=_blogDal.Get(x=>x.Id== id);    

                _blogDal.Delete(blog);
                return new SuccessResult("blog is removed");

            }
            catch (Exception)
            {
                return new ErrorResult("Error");
            }
        }

        public IResult Update(Blog blog)
        {
            try
            {
                
                _blogDal.Update(blog);
                return new SuccessResult("Blog is succesfully update");
            }
            catch (Exception)
            {

                 return new ErrorResult("error");
            }
        }
            
    }
}
