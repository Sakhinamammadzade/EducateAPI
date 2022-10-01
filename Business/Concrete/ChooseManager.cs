using Business.Abstract;
using Business.Constance;
using Core.Helpers.Results.Abstract;
using Core.Helpers.Results.Concrete.ErrorResult;
using Core.Helpers.Results.Concrete.SuccessResult;
using DataAccess.Abstract;
using Entities.Concrete;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ChooseManager : IChooseManager
    {
        private readonly IChooseDal _chooseDal;

        public ChooseManager(IChooseDal chooseDal)
        {
            _chooseDal = chooseDal;
        }

        public IResult Add(ChooseCourse choose)
        {
            try
            {
                _chooseDal.Add(choose);
                return new SuccessResult(Message.ChooseAdded);
            }
            catch (Exception)
            {

                return new ErrorResult(Message.ChooseNotAdded);
            }
          
        }

        public IDataResult<ChooseCourse> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
