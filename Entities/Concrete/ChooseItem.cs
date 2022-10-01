using Core.DataAccess.MongoDb.MongoSettings;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    [BsonCollection("about_course")]
    public class ChooseItem
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public ObjectId _id;
        public string Title { get; set; }
        public string Description { get; set; }
        public string icon { get; set; }
    }
}
