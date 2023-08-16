using Core.Entity.Concrete;

namespace Core.DataAccessLayer.Abstract
{
    public interface IBlogDal : IEntityRepository<Blog>
    {
        List<Blog> GetListWithCategory();
    }
}
