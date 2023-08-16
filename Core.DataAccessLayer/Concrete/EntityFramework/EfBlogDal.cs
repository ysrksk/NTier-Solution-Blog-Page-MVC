using Core.DataAccessLayer.Abstract;
using Core.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccessLayer.Concrete.EntityFramework;

public class EfBlogDal : EfEntityRepositoryBase<Blog, BlogContext>, IBlogDal
{
    public List<Blog> GetListWithCategory()
    {
        using (var db = new BlogContext())
        {
            return db.Blogs.Include("Category").ToList();
        }
    }
}
