using Core.BusinessLayer.Abstract;
using Core.DataAccessLayer.Abstract;
using Core.Entity.Concrete;

namespace Core.BusinessLayer.Concrete;

public class BlogManager : IBlogService
{

	IBlogDal _blogDal;
	public BlogManager(IBlogDal blogDal)
	{
		_blogDal = blogDal;
	}

	public void AddBlog(Blog blog)
	{
		_blogDal.Add(blog);
	}

	public void DeleteBlog(Blog blog)
	{
		_blogDal.Delete(blog);
	}

	public Blog GetBlogById(int id)
	{
		var blog = _blogDal.Get(x => x.BlogId == id);
		return blog;
	}

	public List<Blog> GetAll()
	{
		return _blogDal.GetAll();
	}

	public void UpdateBlog(Blog blog)
	{
		_blogDal.Update(blog);
	}

	public List<Blog> GetListWithCategory()
	{
		return _blogDal.GetListWithCategory();
	}
}
