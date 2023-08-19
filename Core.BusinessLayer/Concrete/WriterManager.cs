using Core.BusinessLayer.Abstract;
using Core.DataAccessLayer.Abstract;
using Core.Entity.Concrete;
using System.Linq.Expressions;

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

	public Writer GetWriterById(Expression<Func<Writer, bool>> filter)
	{
		var writer = _writerDal.Get(filter);
		return writer;
	}

	public List<Writer> GetAllWriter(Expression<Func<Writer, bool>> filter = null)
	{
		return filter == null ? _writerDal.GetAll() : _writerDal.GetAll(filter);

	}

	public void UpdateWriter(Writer writer)
	{
		_writerDal.Update(writer);
	}
}
