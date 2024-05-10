using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportNewspeper_core.Models;
namespace SportNewspeper_core.EntityConfegration
{
    public class AdminEntityconfgration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Admin> builder)
        {
          
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(X=> X.Name).IsRequired(false); 
            builder.Property(X => X.Password).IsRequired(true);
            builder.Property(x => x.Email).IsRequired(true).HasMaxLength(50);
            builder.Property(x=>x.PhoneNumber).IsRequired(false).HasMaxLength(10);
            builder.HasIndex(x => x.Email).IsUnique(true);
            builder.HasIndex(x=> x.PhoneNumber).IsUnique(true);
            builder.ToTable(x => x.HasCheckConstraint("Ch_Admin_Name", "len(Name)>5"));
            builder.ToTable(x => x.HasCheckConstraint("Ch_Admin_Email", "Email Like '%@gmail.com%' Or Email Like  '%@outlook.com%' or Email Like '%@yahoo.com%'"));
            builder.ToTable(x => x.HasCheckConstraint("Ch_Admin_Phone", "(len([PhoneNumber])=(10) AND ([PhoneNumber] like '079%' OR [PhoneNumber] like '078%' OR [PhoneNumber] like '077%'))"));
            builder.ToTable(x => x.HasCheckConstraint("Ch_Admin_Password", "LEN(password) >= 8 AND LEN(password) <= 16"));


        }
    }
}
