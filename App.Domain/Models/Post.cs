using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using App.Domain.Models.Common;
namespace App.Domain.Models
{
    public class Post : AuditableEntity
    {

        [BsonElement("UserName")]
        public string Userid { get; set; }

        [BsonElement("PostTitle")]
        public string PostTitle { get; set; }

        [BsonElement("Rate")]
        public double Rate { get; set; }

        [BsonElement("PhotoUrl")]
        public string PhotoUrl { get; set; }

        [BsonElement("Time")]
        public DateTime Time { get; set; }
        [BsonElement("Comments")]
        public List<string> CommentsIds { get; set; }
        [BsonElement("Likes")]
        public List<string> LikesIds { get; set; }

    }
}