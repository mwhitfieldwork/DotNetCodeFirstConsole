using EntityFrameworkNet5.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkNet5.Data
{
    public class FootballLeagueDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=FootballLeague_EFCore");
            optionsBuilder.UseSqlServer("Server=DESKTOP-KLVRS0S\\SQLEXPRESS;Database=FootballLeague_EFCore;Trusted_Connection=True;MultipleActiveResultSets=true;")
                .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information)
                .EnableSensitiveDataLogging();//you dont want this in production
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Coach> Coaches { get; set; }

    }
}
