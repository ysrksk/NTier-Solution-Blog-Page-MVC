using Core.Entity.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Core.Entity.Concrete;

public class Blog : IEntity
{
	[Key]
	public int BlogId { get; set; }
	public string BlogTitle { get; set; }
	public string BlogContent { get; set; }
	public string BlogThumbnailImage { get; set; }
	public string BlogImage { get; set; }
	public DateTime BlogCreateDate { get; set; }
	public bool BlogStatus { get; set; }
	public int CategoryID { get; set; }
	public int WriterID { get; set; }

	public Writer Writer { get; set; }
	public Category Category { get; set; }
	public ICollection<Comment> Comments { get; set; }
}
