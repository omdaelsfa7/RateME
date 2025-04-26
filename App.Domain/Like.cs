using System.ComponentModel.DataAnnotations;
namespace App.Domain
{
    public class Like
    {
        [Key]
        public int LikeID { get; set; }

        [Required]
        public User User { get; set; }

        [Timestamp]
        public DateTime Time { get; set; }

        [Required]
        public Post Post { get; set; }

    }
}