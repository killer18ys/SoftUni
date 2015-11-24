using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_20_11_2015.Models
{
    public static class League
    {
        private static List<Team> teams = new List<Team>();
        private static List<Match> matches = new List<Match>();

        public static IEnumerable<Team> Teams{
            get { return teams; }
        }

        public static IEnumerable<Match> Matches
        {
            get { return matches; }
        }

        public static void AddTeam(Team team)
        {
            if (CheckIfTeamExists(team))
            {
                throw new InvalidOperationException("Team with that name already exists!");
            }
            teams.Add(team);
        }

        public static bool CheckIfTeamExists(Team team)
        {
            return teams.Any(t => t.Name == team.Name);
        }


        public static void AddMatch(Match match)
        {
            if (CheckIfMatchExists(match))
            {
                throw new InvalidOperationException("Match with that Id already exists!");
            }
            matches.Add(match);
        }

        public static bool CheckIfMatchExists(Match match)
        {
            return matches.Any(m => m.Id == match.Id);
        }
    }
}
