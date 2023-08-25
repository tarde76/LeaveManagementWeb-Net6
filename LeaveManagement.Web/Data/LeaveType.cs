using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LeaveManagement.Web.Data
{
    public class LeaveType : BaseEntity
    {
        [Display(Name = "Leave type name")]
        public string Name { get; set; }
        [Display(Name = "Default days")]
        public int DefaultDays { get; set; }
        public virtual List<LeaveAllocation>? LeaveAllocations { get; set; }
    }
}
