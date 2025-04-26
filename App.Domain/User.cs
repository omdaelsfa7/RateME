using System.ComponentModel.DataAnnotations;
namespace   App.Domain{

    public class User
    {
        [Key]
        public string UserName { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Url]
        public string PfpUrl { get; set; }

        public ICollection<User> Followers { get; set; }
        public ICollection<User> Following { get; set; }
        public ICollection<Like> LikedPosts { get; set; }
        public ICollection<Comment> Comments { get; set; }

        public string Bio { get; set; }
    }
}