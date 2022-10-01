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
    [BsonCollection("Course_content")]
    public class Course:IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public  ObjectId _id;
        public string Name{ get; set; }
        public string Description{ get; set; }
        public string photoUrl{ get; set; }
        public string UserId{ get; set; }
        public decimal Rating{ get; set; }
        public decimal Duraction{ get; set; }
        public decimal Price{ get; set; }

        public List<CourseContent> CourseContents { get; set; }


    }
}
