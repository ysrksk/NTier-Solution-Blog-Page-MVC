using Core.Entity.Concrete;

namespace Core.BusinessLayer.Abstract;

public interface IAboutService
{
    void AddAbout(About about);
    void UpdateAbout(About about);
    void DeleteAbout(About about);
    About GetAboutById(int id);
    List<About> GetAllAbout();
}
