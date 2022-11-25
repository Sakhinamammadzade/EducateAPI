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
    public class AboutManager : IAboutManager
    {
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public IResult Add(About about)
        {
            try
            {
                _aboutDal.Add(about);
                return new SuccessResult(Message.AboutAdded);
            }
            catch
            {
                return new ErrorResult(Message.AboutNotAdded);
            }
         

            
        }

        public IDataResult<List<About>> GetAll()
        {
            try
            {
                var about = _aboutDal.GetAll();
                return new SuccessDataResult<List<About>>(about);

            }
            catch (Exception)
            {

                return  new ErrorDataResult<List<About>>(Message.AboutNotFound);
            }
        }

        public IDataResult<About> GetById(string id)
        {
            try
            {
                var about = _aboutDal.Get(x => x._id == id);
                return new SuccessDataResult<About>(about);
            }
            catch (Exception)
            {

                return new ErrorDataResult<About>(Message.AboutNotFound);
            }
        }

        public IResult Remove(string id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(string id)
        {
            throw new NotImplementedException();
        }
    }
}
