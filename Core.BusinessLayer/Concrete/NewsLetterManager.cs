using Core.BusinessLayer.Abstract;
using Core.DataAccessLayer.Abstract;
using Core.Entity.Concrete;

namespace Core.BusinessLayer.Concrete;

public class NewsLetterManager : INewsLetterService
{
    INewsLetterDal _newsLetterDal;

    public NewsLetterManager(INewsLetterDal newsLetterDal)
    {
        _newsLetterDal = newsLetterDal;
    }

    public void Add(NewsLetter newsLetter)
    {
        _newsLetterDal.Add(newsLetter);
    }

    public void Delete(NewsLetter newsLetter)
    {
        throw new NotImplementedException();
    }

    public List<NewsLetter> GetAll()
    {
        throw new NotImplementedException();
    }

    public NewsLetter GettById(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(NewsLetter newsLetter)
    {
        throw new NotImplementedException();
    }
}
