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

        public DbSet<ProjetA.Shared.Agent> Agent { get; set; }

        public DbSet<ProjetA.Shared.Mail> Mail { get; set; }

        public DbSet<ProjetA.Shared.Position> Position { get; set; }
    }
}
