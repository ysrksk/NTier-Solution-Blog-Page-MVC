using Core.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccessLayer.Concrete.EntityFramework;

public class BlogContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost; Database=CoreBlogDb;Integrated Security=True; TrustServerCertificate=True");
    }

    public DbSet<About> Abouts { get; set; }
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Writer> Writers { get; set; }
    public DbSet<NewsLetter> NewsLetter { get; set; }
    public DbSet<BlogRating> BlogRatings { get; set; }
    public DbSet<Notification> Notifications { get; set; }
}
