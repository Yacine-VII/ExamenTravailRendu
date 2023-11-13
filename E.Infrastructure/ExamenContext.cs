using E.ApplicationCore.Domain;
using E.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.Infrastructure
{
    public class ExamenContext:DbContext
    {
        public DbSet<Athlete> Athletes { get; set; }
        public DbSet<Entrainement> Entrainements { get; set; }
        public DbSet<Piscine> Piscines { get; set; }
        public DbSet<PlanEntrainement> PlanEntrainements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
                Initial Catalog=BeautyMohamedYacineBenAbda;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //3
            modelBuilder.ApplyConfiguration(new PlanEntrainementConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            //4
            configurationBuilder.Properties<string>().HaveMaxLength(100);
            base.ConfigureConventions(configurationBuilder);
        }
    }
}
