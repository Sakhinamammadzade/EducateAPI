using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.DataAccess.MongoDb.MongoSettings;

namespace Entities.Concrete
{
    [BsonCollection("course_category")]
    public class CourseCategory:IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id;
        public string CategoryName { get; set; }


    }
}
