using Core.Entity.Concrete;

namespace Core.BusinessLayer.Abstract;

public interface IBlogService
{
    void AddBlog(Blog blog);
    void UpdateBlog(Blog blog);
    void DeleteBlog(Blog blog);
    Blog GetBlogById(int id);
    List<Blog> GetAllBlog();
}
