using Core.DataAccess.MongoDb.MongoSettings;
using Core.Entities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    [BsonCollection("Courses")]
    public class Course:IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public  string _id;
        public string Name{ get; set; }
        public string Description{ get; set; }
        public string photoUrl{ get; set; }
        public int UserId{ get; set; }
        public decimal Rating{ get; set; }
        public decimal Duraction{ get; set; }
        public decimal Price{ get; set; }
        [BsonElement ("course_category")]
        public string CategoryId { get; set; }
        public List<CourseContent> CourseContents { get; set; }


    }
}
