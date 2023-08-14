using Core.Entity.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Core.Entity.Concrete;

public class Contact : IEntity
{
    [Key]
    public int ContacttId { get; set; }
    public string ContactUserName { get; set; }
    public string ContactMail { get; set; }
    public string ContactSubject { get; set; }
    public string ContactMessage { get; set; }
    public DateTime ContactDate { get; set; }
    public bool ContactStatus { get; set; }
}
