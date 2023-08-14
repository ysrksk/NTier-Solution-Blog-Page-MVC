using Core.BusinessLayer.Abstract;
using Core.DataAccessLayer.Abstract;
using Core.Entity.Concrete;

namespace Core.BusinessLayer.Concrete;

public class AboutManager : IAboutService
{

    IAboutDal _aboutDal;
    public AboutManager(IAboutDal aboutDal)
    {
        _aboutDal = aboutDal;
    }

    public void AddAbout(About about)
    {
        _aboutDal.Add(about);
    }

    public void DeleteAbout(About about)
    {
        _aboutDal.Delete(about);
    }

    public About GetAboutById(int id)
    {
        var about = _aboutDal.Get(x => x.AboutId == id);
        return about;
    }

    public List<About> GetAllAbout()
    {
        return _aboutDal.GetAll();
    }

    public void UpdateAbout(About about)
    {
        _aboutDal.Update(about);
    }
}
