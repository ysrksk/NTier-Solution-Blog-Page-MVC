using Core.DataAccessLayer.Abstract;
using Core.Entity.Concrete;

namespace Core.DataAccessLayer.Concrete.EntityFramework;

public class EfBlogDal : EfEntityRepositoryBase<Blog, BlogContext>, IBlogDal
{
}
