
using MongoDB.Bson;

namespace JM.Database.Repository
{
    interface IMongoEntity
    {
        ObjectId Id { get; set; }
    }
}
