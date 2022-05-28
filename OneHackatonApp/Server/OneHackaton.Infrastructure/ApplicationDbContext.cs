using Microsoft.EntityFrameworkCore;
using OneHackaton.Domain.Entities;
using OneHackaton.Infrastructure.DummyData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHackaton.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<Developer> Developers { get; set; }
        public virtual DbSet<Team> Teams{ get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<DeveloperItem> DeveloperItems { get; set; }
        public virtual DbSet<UserItem> UserItems { get; set; }
        public virtual DbSet<Timeline> TimeLines { get; set; }
        public virtual DbSet<Raport> Raports { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Developer>()
                .HasOne(p => p.Team)
                .WithMany(b => b.Developers);

            modelBuilder.Entity<Project>()
               .HasOne(p => p.Team)
               .WithMany(b => b.Projects);


            modelBuilder.Entity<DeveloperItem>(d =>
            {
                d.HasData(DummyDeveloperItems.GetDeveloperItems());
            });
            modelBuilder.Entity<Developer>(d =>
            {
                d.HasData(DummyDevelopers.GetDevelopers());
            });
            modelBuilder.Entity<Client>(d =>
            {
                d.HasData(DummyClient.GetClients());
            });
            modelBuilder.Entity<Project>(d =>
            {
                d.HasData(DummyProjects.GetProjects());
            });
            modelBuilder.Entity<Team>(d =>
            {
                d.HasData(DumyTeams.GetTeams());
            });
            modelBuilder.Entity<Timeline>(d =>
            {
                d.HasData(DummyTimeLines.GetTimeLines());
            });
            modelBuilder.Entity<User>(d =>
            {
                d.HasData(DummyUser.GetUsers());
            });
            modelBuilder.Entity<UserItem>(d =>
            {
                d.HasData(DummyUserItems.GetUserItems());
            });
        }
    }
}
