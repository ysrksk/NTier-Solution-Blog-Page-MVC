using Core.DataAccessLayer.Abstract;
using Core.Entity.Concrete;

namespace Core.DataAccessLayer.Concrete.EntityFramework;

public class EfContactDal : EfEntityRepositoryBase<Contact, BlogContext>, IContactDal
{
}
