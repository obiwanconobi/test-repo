using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using shearwell_test.Models;

namespace shearwell_test.DataAccess.Maps
{
    public class AnimalGroupRelMap : IEntityTypeConfiguration<AnimalGroupRel>
    {
        public void Configure(EntityTypeBuilder<AnimalGroupRel> builder)
        {
            builder.ToTable("AnimalGroupRel");
            builder.HasKey(x => new { x.AnimalId, x.GroupId });

            builder.Property(t => t.AnimalId).HasColumnName("AnimalId");
            builder.Property(t => t.GroupId).HasColumnName("GroupId");

        }
    }
}
