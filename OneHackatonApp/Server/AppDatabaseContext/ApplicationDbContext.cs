﻿using Microsoft.EntityFrameworkCore;
using OneHackaton.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDatabaseContext
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<Developer> Developers { get; set; }
        public virtual DbSet<Team> Teams{ get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>()
                .HasOne(p => p.Blog)
                .WithMany(b => b.Posts);
        }
    }
}
