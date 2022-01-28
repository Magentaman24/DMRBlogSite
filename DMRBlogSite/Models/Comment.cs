using System.ComponentModel.DataAnnotations;

namespace DMRBlogSite.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public int PostId { get; set; }
        public BlogPost Post { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public DateTime CommentDate { get; set; } = DateTime.Now;
        public string Body { get; set; }
        public string Email { get; set; }
    }
}
