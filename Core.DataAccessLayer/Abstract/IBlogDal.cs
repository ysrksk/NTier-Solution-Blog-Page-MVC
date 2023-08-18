using Core.Entity.Concrete;
using System.Linq.Expressions;

namespace Core.DataAccessLayer.Abstract
{
	public interface IBlogDal : IEntityRepository<Blog>
	{
		List<Blog> GetListWithCategory();
		List<Blog> GetListWithWriter(Expression<Func<Blog, bool>> filter);
	}
}
