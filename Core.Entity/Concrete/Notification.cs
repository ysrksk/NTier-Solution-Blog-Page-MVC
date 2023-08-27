using Core.Entity.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Core.Entity.Concrete
{
    public class Notification : IEntity
    {
        [Key]
        public int NotificationId { get; set; }
        public string Type { get; set; }
        public string TypeSymbol { get; set; }
        public string Details { get; set; }
        public bool Status { get; set; }
        public string Color { get; set; }
        public DateTime NoticationDate { get; set; }
    }
}
