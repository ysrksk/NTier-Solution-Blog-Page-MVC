using Core.DataAccessLayer.Abstract;
using Core.Entity.Concrete;

namespace Core.DataAccessLayer.Concrete.EntityFramework
{
    public class EfNotificationDal : EfEntityRepositoryBase<Notification, BlogContext>, INotificationDal
    {
    }
}
