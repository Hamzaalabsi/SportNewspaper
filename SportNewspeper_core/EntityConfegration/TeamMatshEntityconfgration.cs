using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportNewspeper_core.Models;
namespace SportNewspeper_core.EntityConfegration
{
    public class TeamMatshEntityconfgration : IEntityTypeConfiguration<TeamMatsh>
    {
        public void Configure(EntityTypeBuilder<TeamMatsh> builder)
        {
         
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
          
        }
    }
}
