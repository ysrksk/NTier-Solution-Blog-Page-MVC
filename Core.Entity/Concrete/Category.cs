using Core.Entity.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Core.Entity.Concrete;

public class Category : IEntity
{
    [Key]
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    public string CategoryDescription { get; set; }
    public bool CategoryStatus { get; set; }

    public ICollection<Blog> Blogs { get; set; }
}
