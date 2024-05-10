using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportNewspeper_core.Models;
namespace SportNewspeper_core.EntityConfegration
{
    public class SubscriptionEntityconfgration : IEntityTypeConfiguration<Subscription>
    {
        public void Configure(EntityTypeBuilder<Subscription> builder)
        {
            
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.subscriptionType).IsRequired();
          
            builder.Property(x => x.Description).IsRequired().HasMaxLength(200);
            builder.Property(x=>x.Price).IsRequired();
            builder.ToTable(x => x.HasCheckConstraint("Ch_Subscription_price", "Price>=0"));
        }
    }
}
