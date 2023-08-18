using Core.Entity.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Core.Entity.Concrete
{
    public class NewsLetter : IEntity
    {
        [Key]
        public int MailId { get; set; }
        public string Mail { get; set; }
        public bool MailStatus { get; set; }
    }
}
