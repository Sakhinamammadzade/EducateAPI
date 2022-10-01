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
    [BsonCollection("choose_course")]

    public class ChooseCourse:IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public ObjectId id;
        public string Title { get; set; }
        public string Description { get; set; }
        public string photoUrl { get; set; }
        public List<ChooseItem> ChooseItems { get; set; }


    }
}
