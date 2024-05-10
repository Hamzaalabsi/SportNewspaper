using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportNewspeper_core.Models;

namespace SportNewspeper_core.EntityConfegration
{
    public class CompetaitionEntityconfgration : IEntityTypeConfiguration<Competaition>
    {
        public void Configure(EntityTypeBuilder<Competaition> builder)
        {
           
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Id).UseIdentityColumn();
            builder.Property(x=>x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x=>x.Description).IsRequired().HasMaxLength(200);
            builder.Property(x=>x.continent).IsRequired();
            builder.Property(x=>x.countries).IsRequired();
            builder.Property(x=>x.sports).IsRequired();
            builder.ToTable(x => x.HasCheckConstraint("CH_Competaition_Name", "len(Name)>5"));
            builder.HasIndex(x => x.Name).IsUnique();
        }
    }
}
