using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;
namespace   App.Domain{

    public class User
    {
        [BsonId]
        public string UserName { get; set; }

        [BsonElement("UserName")]
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

        public List<User> Followers { get; set; }
        public List<User> Following { get; set; }
        public List<Like> LikedPosts { get; set; }
        public List<Comment> Comments { get; set; }

        
    }
}