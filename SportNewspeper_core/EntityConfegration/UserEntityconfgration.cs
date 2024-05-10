using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportNewspeper_core.Models;

namespace SportNewspeper_core.EntityConfegration
{
    public class UserEntityconfgration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
           
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(X => X.Name).IsRequired(false).HasMaxLength(20);
            builder.Property(X => X.Password).IsRequired(true).HasMaxLength(20);
            builder.Property(x => x.Email).IsRequired(true).HasMaxLength(50);
            builder.Property(x => x.PhoneNumber).IsRequired(false).HasMaxLength(10);
            builder.Property(x=>x.IsActive).IsRequired(true).HasDefaultValue(true);
            builder.HasIndex(x => x.Email).IsUnique(true);
            builder.HasIndex(x => x.PhoneNumber).IsUnique(true);
            builder.ToTable(x => x.HasCheckConstraint("CH_User_Name", "len(Name)>5"));
            builder.ToTable(x => x.HasCheckConstraint("CH_User_Email", "Email Like '%@gmail.com%' Or Email Like  '%@outlook.com%' or Email Like '%@yahoo.com%'"));
            builder.ToTable(x => x.HasCheckConstraint("ch_User_Phone", "(len([PhoneNumber])=(10) AND ([PhoneNumber] like '079%' OR [PhoneNumber] like '078%' OR [PhoneNumber] like '077%'))"));
            builder.ToTable(x => x.HasCheckConstraint("CH_User_Password", "LEN(password) >= 8 AND LEN(password) <= 16"));

        }
    }
}
