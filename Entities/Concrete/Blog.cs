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
    [BsonCollection("Courses")]
    public  class Blog:IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id;
        public string Title { get; set; }
        public string Description { get; set; }
        public string PhotoUrl { get; set; }
        public bool IsDelete { get; set; }

    }
}
