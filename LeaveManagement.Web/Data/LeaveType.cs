namespace LeaveManagement.Web.Data
{
    public class LeaveType : BaseEntity
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
        public virtual List<LeaveAllocation> LeaveAllocations { get; set; }
    }
}
