using EntityFrameworkNet5.Data;
using EntityFrameworkNet5.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkConsoleAppNet5
{
    class Program
    {
        private static FootballLeagueDbContext context = new FootballLeagueDbContext();

        static async Task Main(string[] args)
        {
            //var league = new League { Name = "New York League" };
            //await context.Leagues.AddAsync(league);
            //await context.SaveChangesAsync(); // use this everytime you wan the code to interact with the database

            //Selecting
            //var teams = context.Teams.ToList();

            //Like
            //var matches await context.Teams.Where(q => Enumerable.fun)

            //Inserting 
            //await AddTeamsWithLeague(league);
            //await context.SaveChangesAsync();

            Console.WriteLine("Hello World!");

            static async Task AddTeamsWithLeague(League league) 
            {
                var teams = new List<Team>
                {
                    new Team
                    {
                        Name = "Giants",
                        League= league
                    },
                    new Team
                    {
                        Name = "Buffalo",
                        League= league
                    },
                    new Team
                    {
                        Name = "Jets",
                        LeaugeId = league.Id
                    }
                };

                await context.AddRangeAsync(teams);
            }

            //updateRecord();
            //updateWholeTeam();
            simpleDelete();
        }

        //Update
        private static void updateWholeTeam()
        {
            var team = new Team
            {
                Id = 3,
                Name = "The Jets",
                LeaugeId = 2
            };
            context.Teams.Update(team);
            context.SaveChanges();
        }
        private static void updateRecord()
        {
            //retreive record

            var team = context.Teams.Find(2);

            //update record

            team.Name = "Bills";

            //save changes
            context.SaveChanges();
        }

        //delete
        private static void simpleDelete()
        {
            var deletedTeam = context.Teams.Find(3);
            context.Teams.Remove(deletedTeam);
            context.SaveChanges();
        }
    }
}
