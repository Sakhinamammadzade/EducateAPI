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
    [BsonCollection("courses")]
    public class Course:IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public  ObjectId _id;
        public string Name{ get; set; }
        public string Description{ get; set; }

    }
}
