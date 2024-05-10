using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportNewspeper_core.Models;

namespace SportNewspeper_core.EntityConfegration
{
    public class NewsEntityconfgration : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> builder)
        {
          
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x=>x.Title).IsRequired().HasMaxLength(200);
            builder.Property(x =>x.Description).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Content).IsRequired();
            builder.Property(x=>x.PublishTime).IsRequired();
            builder.Property(x=>x.VedeoPath).IsRequired(false);
            builder.Property(x => x.ImagePath).IsRequired(false);
            builder.Property(x=>x.IsImportant).IsRequired().HasDefaultValue(true);
            ;

        }
    }
}
