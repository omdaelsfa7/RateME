using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace App.Domain{
    public class Post
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int PostID { get; set; }

        [BsonElement("UserName")]
        public User User { get; set; }

        [BsonElement("PostTitle")]
        public string PostTitle { get; set; }

        [BsonElement("Rate")]
        public double Rate { get; set; }

        [BsonElement("PhotoUrl")]
        public string PhotoUrl { get; set; }

        [BsonElement("Time")]
        public DateTime Time { get; set; }
        [BsonElement("Comments")]
        public List<Comment> Comments { get; set; }
        [BsonElement("Likes")]
        public List<Like> Likes { get; set; }

    }
}