using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportNewspeper_core.Models;

namespace SportNewspeper_core.EntityConfegration
{
    public class CompetaitionTemsEntityconfgration : IEntityTypeConfiguration<CompetaitionTems>
    {
        public void Configure(EntityTypeBuilder<CompetaitionTems> builder)
        {
         
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
        
        }
    }
}
