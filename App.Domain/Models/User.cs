using System.ComponentModel.DataAnnotations;
using App.Domain.Models.Common;
using MongoDB.Bson.Serialization.Attributes;
namespace App.Domain.Models
{

    public class User : AuditableEntity
    {
        [BsonElement("UserName")]
        public string UserName { get; set; }

        [BsonElement("FullName")]
        public string FullName { get; set; }

        [BsonElement("PhoneNumber")]
        public string PhoneNumber { get; set; }

        [BsonElement("Email")]
        public string Email { get; set; }

        [BsonElement("Password")]
        public string Password { get; set; }

        [BsonElement("PfpUrl")]
        public string PfpUrl { get; set; }

        [BsonElement("Bio")]
        public string Bio { get; set; }

        public List<string> FollowersIds { get; set; }
        public List<string> FollowingIds { get; set; }
        public List<string> LikedPostsIds { get; set; }
        public List<string> CommentsIds { get; set; }

    }
}