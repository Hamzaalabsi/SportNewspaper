using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportNewspeper_core.Models;

namespace SportNewspeper_core.EntityConfegration
{
    public class MatchEntityconfgration : IEntityTypeConfiguration<Match>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Match> builder)
        {
           
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Description).IsRequired().HasMaxLength(200);
            builder.Property(x => x.StadiumName).IsRequired(false).HasMaxLength(50);
            builder.Property(x => x.RefereeName).IsRequired(false).HasMaxLength(50);
            builder.Property(x => x.IsImportant).IsRequired().HasDefaultValue(true);
            builder.Property(x => x.continent).IsRequired();
            builder.Property(x => x.countries).IsRequired();
            builder.Property(x => x.sports).IsRequired();
            builder.Property(x => x.StartTime).IsRequired().HasDefaultValue(DateTime.Now);





        }
    }
}
