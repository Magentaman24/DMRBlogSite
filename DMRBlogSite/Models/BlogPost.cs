using System.ComponentModel.DataAnnotations;

namespace DMRBlogSite.Models
{
    public class BlogPost
    {
        [Key]
        public int PostId { get; set; }
        public string Title {get; set;}    
        public List<Comment> Comments { get; set; }
        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; } = DateTime.Now;

        public string Body { get; set; }    
       
    }
}
