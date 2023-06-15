using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LeaveManagement.Web.Data.Configurations.Entities
{
    public class LeaveTypeConfiguration : IEntityTypeConfiguration<LeaveType>
    {
        public void Configure(EntityTypeBuilder<LeaveType> builder)
        {
            builder.HasMany(x => x.LeaveAllocations)
                   .WithOne(x => x.LeaveType)
                   .HasForeignKey(x => x.LeaveTypeId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
