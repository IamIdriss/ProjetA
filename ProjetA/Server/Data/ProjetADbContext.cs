#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetA.Shared;

namespace ProjetA.Server.Data
{
    public class ProjetADbContext : DbContext
    {
        public ProjetADbContext (DbContextOptions<ProjetADbContext> options)
            : base(options)
        {
        }
        private const string connectionString = "Server=DESKTOP-JDGBI4U;Database=ProjetADB;Trusted_Connection=True;MultipleActiveResultSets=true;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(connectionString);
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProjetA.Shared.Mail>()
                .Property(Mail => Mail.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<ProjetA.Shared.Agent>()
               .Property(Agent => Agent.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<ProjetA.Shared.Position>()
               .Property(Position => Position.Id).ValueGeneratedOnAdd();

        }

        public DbSet<ProjetA.Shared.Agent> Agent { get; set; }

        public DbSet<ProjetA.Shared.Mail> Mail { get; set; }

        public DbSet<ProjetA.Shared.Position> Position { get; set; }
    }
}
