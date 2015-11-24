using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_20_11_2015.Models
{
    public class Match
    {
        private Team homeTeam;
        private Team awayTeam;
        private Score score;
        private int id;

        public Match(Team homeTeam, Team awayTeam, Score score, int id)
        {
            this.HomeTeam = homeTeam;
            this.AwayTeam = awayTeam;
            this.Score = score;
            this.Id = id;
        }

        public Team HomeTeam 
        {
            get { return this.homeTeam; }
            set { this.homeTeam = value; }
        }
        public Team AwayTeam
        {
            get { return this.awayTeam; }
            set { this.awayTeam = value; }
        }

        public Score Score
        {
            get { return this.score; }
            set { this.score = value; }
        }

        public int Id
        {
            get { return this.id; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Id cannot be negative!");
                }
                this.id = value;
            }
        }

        public Team GetWinner()
        {
            if (this.IsDraw())
            {
                return null;
            }

            return this.Score.HomeTeamGoals > this.Score.AwayTeamGoals
                ? this.HomeTeam
                : this.AwayTeam;
        }

        public bool IsDraw()
        {
            return this.Score.AwayTeamGoals == this.Score.HomeTeamGoals;
        }

        public override string ToString()
        {
            return string.Format("Id {0} - {1} vs {2} {3}", this.id, this.HomeTeam.Name, this.AwayTeam.Name, this.Score);
        }

    }
}
