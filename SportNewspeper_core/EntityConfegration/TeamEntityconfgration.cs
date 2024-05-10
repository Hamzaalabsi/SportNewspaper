using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportNewspeper_core.Models;
namespace SportNewspeper_core.EntityConfegration
{
    public class TeamEntityconfgration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Description).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.continent).IsRequired();
            builder.Property(x => x.countries).IsRequired();
            builder.Property(x => x.sports).IsRequired();
            builder.Property(x => x.CoachName).IsRequired(false);
            builder.Property(x => x.FoundingDate).IsRequired(false);


            builder.ToTable(x => x.HasCheckConstraint("CH_Competaition_Name", "len(Name)>5"));
            builder.HasIndex(x => x.Name).IsUnique();

        }
    }
}
