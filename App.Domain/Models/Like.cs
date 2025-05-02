using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using App.Domain.Models.Common;
namespace App.Domain.Models
{
    public class Like : BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int LikeID { get; set; }

        [BsonElement("User")]
        public string UserId { get; set; }

        [BsonElement("Time")]
        public DateTime Time { get; set; }

        [BsonElement("Post")]
        public String PostId { get; set; }

    }
}