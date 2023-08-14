using Core.Entity.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Core.Entity.Concrete;

public class About : IEntity
{
    [Key]
    public int AboutId { get; set; }
    public string AboutDetails1 { get; set; }
    public string AboutDetails2 { get; set; }
    public string AboutImage1 { get; set; }
    public string AboutImage2 { get; set; }
    public string AboutMapLocation { get; set; }
    public bool AboutStatus { get; set; }
}
