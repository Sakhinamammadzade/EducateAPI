﻿using Core.DataAccess.EntitiyFramework;
using Core.DataAccess.MongoDb;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Mongo
{
    public class ChooseDal: MongoEntityRepositoryBase<ChooseCourse>, IChooseDal
    {
    }
}
