using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_20_11_2015.Models
{
    public class Player
    {
        private const int MinimumAllowedYears = 1980;

        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;
        private decimal salary;
        private Team team;


        public Player(string firstName, string lastName, DateTime dateOfBirth, decimal salary, Team team)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Salary = salary;
            this.Team = team;
        }


        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (!IsNameValid(value))
                {
                    throw new ArgumentException("First name should be at leat 3 chars long");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (!IsNameValid(value))
                {
                    throw new ArgumentException("First name should be at leat 3 chars long");
                }
                this.lastName = value;
            }
        }

        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary cannot be negative number!");
                }
                this.salary = value;
            }
        }

        public DateTime DateOfBirth
        {
            get { return this.dateOfBirth; }
            set
            {
                if (value.Year < MinimumAllowedYears)
                {
                    throw new ArgumentException("Date of birth cannot be earlier than " + MinimumAllowedYears);
                }
                this.dateOfBirth = value;
            }
        }

        public Team Team
        {
            get { return this.team; }
            set { this.team = value; }
        }



        public bool IsNameValid(string value)
        {
            return !(string.IsNullOrWhiteSpace(value) || value.Length < 3);
        }


    }
}
