namespace Core.BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void Add(T Entity);
        void Update(T Entity);
        void Delete(T Entity);
        T GetById(int id);
        List<T> GetAll();
    }
}
