using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_20_11_2015.Models
{
    public class Team
    {
        private const int MinimumAllowedYear = 1850;

        private string name;
        private string nickname;
        private DateTime dateFouned;
        private List<Player> players;


        public Team(string name, string nickname, DateTime dateFounded)
        {
            this.Name = name;
            this.Nickname = nickname;
            this.DateFouned = dateFounded;
            this.players = new List<Player>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (!IsNameValid(value))
                {
                    throw new ArgumentException("Name cannot be shorter than 5 letters");
                }
                this.name = value;
            }
        }

        public string Nickname
        {
            get { return this.nickname; }
            set
            {
                if (!IsNameValid(value))
                {
                    throw new ArgumentException("Name cannot be shorter than 5 letters");
                }
                this.nickname = value;
            }
        }



        public DateTime DateFouned
        {
            get { return this.dateFouned; }
            set
            {
                if (value.Year < MinimumAllowedYear)
                {
                    throw new ArgumentOutOfRangeException("The foundation date should be earlier than" + MinimumAllowedYear);
                }
                this.dateFouned = value;
            }
        }



        public IEnumerable<Player> Players
        {
            get { return this.players; }
        }


        public void AddPlayer(Player player)
        {
            if (CheckIfPlayerExists(player))
            {
                throw new InvalidOperationException("Player already exists for that team!");
            }
            this.players.Add(player);
        }

        public bool CheckIfPlayerExists(Player player)
        {
            return this.players.Any(p => p.FirstName == player.FirstName &&
                                         p.LastName == player.LastName);
        }



        public bool IsNameValid(string value)
        {
            return !(string.IsNullOrWhiteSpace(value) || value.Length < 5);
        }


        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine();
            result.Append("Name: ").AppendLine(this.Name);
            result.Append("NickName: ").AppendLine(this.Nickname);
            result.Append("Date of fundation: ").AppendLine(this.DateFouned.Date.ToString());
            result.AppendLine("Players: ");
            this.players.ToList().ForEach(p => result.AppendLine(p.FirstName + " " + p.LastName));
            result.AppendLine();

            return result.ToString();
        }
    }
}
