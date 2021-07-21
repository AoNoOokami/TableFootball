using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TableFootball.Models;

namespace TableFootball.Data
{
    public class DBInitializer
    {
        public static void Initialize(TableFootballContext context)
        {
            context.Database.EnsureCreated();

            // Look for any players.
            if (context.Players.Any())
            {
                return;   // DB has been seeded
            }

            var players = new Player[]
            {
                new Player{Name="Camille"},
                new Player{Name="Dominique"}
            };

            foreach (Player p in players)
            {
                context.Players.Add(p);
            }

            context.SaveChanges();

            var teams = new Team[]
            {
                new Team{Name="Camille", GoalsFor=0, GoalsAgainst=0, Wins=0, Losses=0},
                new Team{Name="Dominique", GoalsFor=0, GoalsAgainst=0, Wins=0, Losses=0}
            };

            foreach (Team t in teams)
            {
                context.Teams.Add(t);
            }

            context.SaveChanges();

            var enrollments = new TeamEnrollment[]
            {
                new TeamEnrollment{PlayerID=1,TeamID=1},
                new TeamEnrollment{PlayerID=2,TeamID=2}
            };

            foreach (TeamEnrollment e in enrollments)
            {
                context.TeamEnrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}
