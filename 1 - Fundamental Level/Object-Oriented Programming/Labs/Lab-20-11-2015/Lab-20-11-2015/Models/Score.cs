using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_20_11_2015.Models
{
    public class Score
    {
        private int homeTeamGoals;
        private int awayTeamGoals;

        public Score(int homeTeamGoals, int awayTeamGoal)
        {
            this.HomeTeamGoals = homeTeamGoals;
            this.AwayTeamGoals = awayTeamGoals;
        }

        public int HomeTeamGoals
        {
            get { return this.homeTeamGoals; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Goals cannot be negative number!");
                }
                this.homeTeamGoals = value;
            }
        }
        public int AwayTeamGoals
        {
            get { return this.awayTeamGoals; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Goals cannot be negative number!");
                }
                this.awayTeamGoals = value;
            }
        }


        public override string ToString()
        {
            return string.Format("{0} : {1}", HomeTeamGoals, AwayTeamGoals);
        }
    }
}
