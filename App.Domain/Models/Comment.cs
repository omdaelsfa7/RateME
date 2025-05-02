using App.Domain.Models.Common;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace App.Domain.Models
{
    public class Comment : AuditableEntity
    {

        [BsonElement("UserId")]
        public string UserId { get; set; }

        [BsonElement("Time")]
        public DateTime Time { get; set; }

        [BsonElement("Post")]
        public string PostId { get; set; }

        [BsonElement("CommentContent")]
        public string CommentContent { get; set; }
    }

}