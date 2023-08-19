using Core.Entity.Concrete;
using System.Linq.Expressions;

namespace Core.BusinessLayer.Abstract;

public interface IWriterService
{
	void AddWriter(Writer writer);
	void UpdateWriter(Writer writer);
	void DeleteWriter(Writer writer);
	Writer GetWriterById(Expression<Func<Writer, bool>> filter);
	List<Writer> GetAllWriter(Expression<Func<Writer, bool>> filter = null);
}
