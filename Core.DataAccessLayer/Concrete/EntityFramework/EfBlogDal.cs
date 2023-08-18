using Core.DataAccessLayer.Abstract;
using Core.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Core.DataAccessLayer.Concrete.EntityFramework;

public class EfBlogDal : EfEntityRepositoryBase<Blog, BlogContext>, IBlogDal
{
	public List<Blog> GetListWithCategory()
	{
		using (var db = new BlogContext())
		{
			return db.Blogs.Include(x => x.Category).ToList();
		}
	}

	public List<Blog> GetListWithWriter(Expression<Func<Blog, bool>> filter)
	{
		using (var db = new BlogContext())
		{
			return db.Blogs.Include(x => x.Writer).ToList();
		}
	}
}
