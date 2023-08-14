using Core.Entity.Concrete;

namespace Core.BusinessLayer.Abstract;

public interface ICategoryService
{
    void AddCategory(Category category);
    void UpdateCategory(Category category);
    void DeleteCategory(Category category);
    Category GetCategoryById(int id);
    List<Category> GetAllCategory();
}
