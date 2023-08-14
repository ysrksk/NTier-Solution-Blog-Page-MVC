using Core.BusinessLayer.Abstract;
using Core.DataAccessLayer.Abstract;
using Core.Entity.Concrete;

namespace Core.BusinessLayer.Concrete;

public class CategoryManager : ICategoryService
{

    ICategoryDal _categoryDal;
    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public void AddCategory(Category category)
    {
        _categoryDal.Add(category);
    }

    public void DeleteCategory(Category category)
    {
        _categoryDal.Delete(category);
    }

    public Category GetCategoryById(int id)
    {
        var Category = _categoryDal.Get(x => x.CategoryId == id);
        return Category;
    }

    public List<Category> GetAllCategory()
    {
        return _categoryDal.GetAll();
    }

    public void UpdateCategory(Category category)
    {
        _categoryDal.Update(category);
    }
}
