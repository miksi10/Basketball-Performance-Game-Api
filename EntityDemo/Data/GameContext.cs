using EntityDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDemo.Data
{
    public class GameContext : DbContext
    {
        public DbSet<Players> Players { get; set; } = null!;

        public DbSet<GamePerformance> GamePerformance { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\FirstLocalDB;Initial Catalog=FirstGame;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // konfigurisanje primarnih kljuceva
            modelBuilder.Entity<Players>().HasKey(k => k.PlayerId);
            modelBuilder.Entity<GamePerformance>().HasKey(k => k.GamePerformanceID);

            modelBuilder.Entity<GamePerformance>()
                .HasOne(p => p.players)
                .WithMany(g => g.gamePerformances)
                .HasForeignKey(p => p.PlayerId);
        }

    }
}
