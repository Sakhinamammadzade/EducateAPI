using Core.DataAccess.MongoDb;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOS;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Mongo
{
    public class CourseCategoyDal : MongoEntityRepositoryBase<CourseCategory>, ICourseCategoryDal
    {
        public List<CourseCategoryDTO> GetContentCategories()
        {
            var database = new MongoClient("mongodb://localhost:27017").GetDatabase("education");
            var course_category = database.GetCollection<CourseCategory>("course_category");
            var res = course_category.Find(x => true).ToList();
            List<CourseCategoryDTO> result = new();

            foreach (var item in res)
            {
                CourseCategoryDTO category = new()
                {
                     Id=item._id,
                     Name=item.CategoryName
                };
                 result.Add(category);
            }
            return result;
        }
    }
}
