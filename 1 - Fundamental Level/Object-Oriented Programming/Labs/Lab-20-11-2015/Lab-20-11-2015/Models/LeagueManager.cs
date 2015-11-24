using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_20_11_2015.Models
{
    public static class LeagueManager
    {

        public static void InputHandler(string input)
        {
            string[] inputArgs = input.Split();

            switch (inputArgs[0])
            {
                case "AddTeam":
                        AddTeam(inputArgs[1], inputArgs[2], DateTime.Parse(inputArgs[3]));
                    break;
                case "AddMatch":
                        AddMatch(int.Parse(inputArgs[1]), inputArgs[2], inputArgs[3], int.Parse(inputArgs[4]), int.Parse(inputArgs[5]));
                    break;
                case "AddPlayerToTeam":
                     AddPlayerToTeam(inputArgs[1], inputArgs[2], DateTime.Parse(inputArgs[3]), decimal.Parse(inputArgs[4]), inputArgs[5]);
                    break;
                case "ListTeams":
                        ListTeams();
                    break;
                case "ListMatches":
                        ListMatches();
                    break;
            }

        }

        private static void AddTeam(string name, string nickname, DateTime dateFounded)
        {
            League.AddTeam(new Team(name, nickname, dateFounded));
            Console.WriteLine("Team {0} was added to the League.", name);
        }


        private static void AddMatch(int id, string homeTeam, string awayTeam, int homeTeamGoals, int awayTeamGoal)
        {
            Team firstTeam = League.Teams.Where(item => item.Name == homeTeam).ToList<Team>().FirstOrDefault();
            Team secondTeam = League.Teams.Where(item => item.Name == awayTeam).ToList<Team>().FirstOrDefault();

            League.AddMatch(new Match(firstTeam, secondTeam, new Score(homeTeamGoals, awayTeamGoal), id));
            Console.WriteLine("Match {0} vs {1} was added to the League.", homeTeam, awayTeam);
        }

        private static void AddPlayerToTeam(string firstName, string lastName, DateTime dateOfBirth, decimal salary, string team)
        {
            Team currTeam = League.Teams.Where(item => item.Name == team).ToList<Team>().FirstOrDefault();
            if (currTeam == null)
            {
                throw new NullReferenceException("This team doesn't exists!");
            }

            currTeam.AddPlayer(new Player(firstName, lastName, dateOfBirth, salary, currTeam));

            Console.WriteLine("The player {0} {1} was added to {2} team.", firstName, lastName, currTeam.Name);
        }

        private static void ListTeams()
        {
            League.Teams.ToList().ForEach(t => Console.WriteLine(t));
        }

        private static void ListMatches()
        {
            League.Matches.ToList().ForEach(m => Console.WriteLine(m));
        }

    }
}
