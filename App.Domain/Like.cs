using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace App.Domain
{
    public class Like
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int LikeID { get; set; }

        [BsonElement("User")]
        public User User { get; set; }

        [BsonElement("Time")]
        public DateTime Time { get; set; }

        [BsonElement("Post")]
        public Post Post { get; set; }

    }
}