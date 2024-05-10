using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportNewspeper_core.Models;
namespace SportNewspeper_core.EntityConfegration
{
    public class TeamNewsEntityconfgration : IEntityTypeConfiguration<TeamNews>
    {
        public void Configure(EntityTypeBuilder<TeamNews> builder)
        {
           
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.CreateTime).IsRequired().HasDefaultValue(DateTime.Now);
        }
    }
}
