using Core.Entity.Concrete;

namespace CoreDemo.Models
{
    public class BlogViewModel
    {
        public Blog Blog { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Comment> Comments { get; set; }
        public NewsLetter NewsLetter { get; set; }

    }
}
