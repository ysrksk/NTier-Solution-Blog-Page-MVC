using Core.BusinessLayer.Abstract;
using Core.DataAccessLayer.Abstract;
using Core.Entity.Concrete;

namespace Core.BusinessLayer.Concrete;

public class WriterManager : IWriterService
{

    IWriterDal _writerDal;
    public WriterManager(IWriterDal WriterDal)
    {
        _writerDal = WriterDal;
    }

    public void AddWriter(Writer writer)
    {
        _writerDal.Add(writer);
    }

    public void DeleteWriter(Writer writer)
    {
        _writerDal.Delete(writer);
    }

    public Writer GetWriterById(int id)
    {
        var writer = _writerDal.Get(x => x.WriterID == id);
        return writer;
    }

    public List<Writer> GetAllWriter()
    {
        return _writerDal.GetAll();
    }

    public void UpdateWriter(Writer writer)
    {
        _writerDal.Update(writer);
    }
}
