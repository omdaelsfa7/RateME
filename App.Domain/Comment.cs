using System.ComponentModel.DataAnnotations;
namespace App.Domain
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }

        [Required]
        public User User { get; set; }

        [Timestamp]
        public DateTime Time { get; set; }

        [Required]
        public Post Post { get; set; }

        [Required]
        public string CommentContent { get; set; }
    }

}