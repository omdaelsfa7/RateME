using MongoDB.Bson.Serialization.Attributes;

namespace App.Domain.Models.Common;

public class BaseEntity
{
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    public string Id { get; set; }

}
