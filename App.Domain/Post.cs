using System.ComponentModel.DataAnnotations;
namespace App.Domain{
    public class Post
    {
        [Key]
        public int PostID { get; set; }

        [Required]
        public User User { get; set; }

        [Required]
        public string PostTitle { get; set; }

        [Required]
        public double Rate { get; set; }

        [Url]
        public string PhotoUrl { get; set; }

        [Timestamp]
        public DateTime Time { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Like> Likes { get; set; }

    }
}