using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.MongoDb.MongoSettings;

namespace Entities.Concrete
{
    [BsonCollection("course_content")]
    public class CourseContent
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public ObjectId _id;
        public string ContentName { get; set; }
        public List<ContentLesson> ContentLessons { get; set; }


    }
}
