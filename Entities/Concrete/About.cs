using Core.DataAccess.MongoDb.MongoSettings;
using Core.Entities;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    [BsonCollection("courses_about")]
    public class About: IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id;
        public string Title { get; set; }
        public string Description { get; set; }
        public string photoUrl { get; set; }

    }
}
