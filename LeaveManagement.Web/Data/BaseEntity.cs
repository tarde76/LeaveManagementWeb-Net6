using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LeaveManagement.Web.Data
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        [Display(Name = "Date created")]
        public DateTime DateCreated { get; set; }
        [Display(Name = "Date modified")]
        public DateTime DateModified { get; set; }
    }
}
