using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace App.Domain
{
    public class Comment
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int CommentID { get; set; }

        [BsonElement("User")]
        public User User { get; set; }

        [BsonElement("Time")]
        public DateTime Time { get; set; }

        [BsonElement("Post")]
        public Post Post { get; set; }

        [BsonElement("CommentContent")]
        public string CommentContent { get; set; }
    }

}