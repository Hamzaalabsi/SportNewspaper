using Microsoft.EntityFrameworkCore;
using SportNewspeper_core.EntityConfegration;
using SportNewspeper_core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNewspeper_core.Context
{
    public class SportNewspaperDbContext : DbContext
    {
        public SportNewspaperDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserEntityconfgration());
            modelBuilder.ApplyConfiguration(new AdminEntityconfgration());
            modelBuilder.ApplyConfiguration(new CompetaitionEntityconfgration());
            modelBuilder.ApplyConfiguration(new MatchEntityconfgration());
            modelBuilder.ApplyConfiguration(new CompetaitionTemsEntityconfgration());
            modelBuilder.ApplyConfiguration(new NewsEntityconfgration());
            modelBuilder.ApplyConfiguration(new TeamEntityconfgration());
            modelBuilder.ApplyConfiguration(new TeamMatshEntityconfgration());
            modelBuilder.ApplyConfiguration(new TeamNewsEntityconfgration());
            modelBuilder.ApplyConfiguration(new UserSubscriptionEntityconfgration());
            modelBuilder.ApplyConfiguration(new SubscriptionEntityconfgration());

        }
        public virtual DbSet<Competaition> competaitions { get; set; }
        public virtual DbSet<Match> matches { get; set; }
        public virtual DbSet<News> news { get; set; }
        public virtual  DbSet<Subscription> subscriptions { get; set; }
        public virtual DbSet<Team> teams { get; set; }
        public virtual DbSet<User> users { get; set; }
        public virtual DbSet<Admin> admins { get; set; }
        public virtual DbSet<TeamMatsh> teamsMatshs { get; set; }
        public virtual DbSet<TeamNews> teamNews { get; set; }
        public virtual DbSet<CompetaitionTems> competaitionTems { get; set; }
        public virtual DbSet<UserSubscription> userSubscriptions { get; set; }


       

    }
}
