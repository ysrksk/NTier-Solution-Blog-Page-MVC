using Core.DataAccessLayer.Abstract;
using Core.Entity.Concrete;

namespace Core.DataAccessLayer.Concrete.EntityFramework;

public class EfWriterDal : EfEntityRepositoryBase<Writer, BlogContext>, IWriterDal
{
}