using Core.Entity.Concrete;

namespace Core.BusinessLayer.Abstract
{
    public interface INewsLetterService
    {
        void Add(NewsLetter newsLetter);
        void Update(NewsLetter newsLetter);
        void Delete(NewsLetter newsLetter);
        NewsLetter GettById(int id);
        List<NewsLetter> GetAll();
    }
}
