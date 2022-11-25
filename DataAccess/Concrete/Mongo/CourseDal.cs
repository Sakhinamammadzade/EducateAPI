using Core.DataAccess.MongoDb;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
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
    public class CourseDal : MongoEntityRepositoryBase<Course>, ICourseDal
    {
        public List<CourseContentDTO> GetCourseContent()
        {
            var database = new MongoClient("mongodb://localhost:27017").GetDatabase("education");
            var courses = database.GetCollection<Course>("Courses");
            var res = courses.Find(x => true).ToList();

            AppDbContext context = new();
            List<CourseContentDTO> result = new();

            foreach (var item in res)
            {
                CourseContentDTO courseContent = new(){ 
                    CategoryId=item.CategoryId,
                    CourseId=item._id,
                    PhotoUrl=item.photoUrl,
                    CourseName=item.Name,
                    AuthorName=context.Users.FirstOrDefault(x=>x.Id==item.UserId).Name

                };
                 result.Add(courseContent);
            }
            return result;

        }
    }
}
