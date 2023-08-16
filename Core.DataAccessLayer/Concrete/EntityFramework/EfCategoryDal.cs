using Core.DataAccessLayer.Abstract;
using Core.Entity.Concrete;

namespace Core.DataAccessLayer.Concrete.EntityFramework;

public class EfCategoryDal : EfEntityRepositoryBase<Category, BlogContext>, ICategoryDal
{

}
