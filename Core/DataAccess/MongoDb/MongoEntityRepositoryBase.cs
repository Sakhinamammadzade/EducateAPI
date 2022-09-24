using Core.DataAccess.MongoDb.MongoSettings;
using Core.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.MongoDb
{
    public class MongoEntityRepositoryBase<TDocument> : IEntitiyRepositoryBase<TDocument>
        where TDocument : class, IEntity, new()
    {
        private readonly IMongoCollection<TDocument> _collection;
        private protected string GetCollectionName(Type documentType)
        {
            return ((BsonCollectionAttribute)documentType.GetCustomAttributes(
                typeof(BsonCollectionAttribute),
                    true)
            .FirstOrDefault())?.CollectionName;

        } 
        public MongoEntityRepositoryBase()
        {
            var database = new MongoClient("").GetDatabase("education");
            _collection=database.GetCollection<TDocument>(GetCollectionName(typeof(TDocument)));
        }
        public void Add(TDocument entity)
        {
            _collection.InsertOne(entity);
        }

        public void Delete(TDocument entity)
        {
            throw new NotImplementedException();
        }

        public TDocument Get(Expression<Func<TDocument, bool>> filter)
        {
            return _collection.Find(filter).FirstOrDefault();
        }

        public List<TDocument> GetAll(Expression<Func<TDocument, bool>> filter = null)
        {
           return _collection.Find(filter).ToList();
        }

        public void Update(TDocument entity)
        {
            throw new NotImplementedException();
        }
    }
}
