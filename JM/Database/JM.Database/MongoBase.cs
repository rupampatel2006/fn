
using JM.Database.Repository;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace JM.Database
{
    public class MongoBase : IMongoEntity
    {
        [BsonId]
        public ObjectId Id { get; set; }
    }
}
