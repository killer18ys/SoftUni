using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_Persons
{
    class Person
    {
        private string name;
        private int age;
        private string email;


        public Person(string name, int age, string email)
        {
            try
            {
                this.Name = name;
                this.Age = age;
                this.Email = email;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public Person(string name, int age)
            : this(name, age, null)
        {

        }


        public string Name 
        {
            get { return this.name; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                       throw new ArgumentException("The name cannot be empty string!");
                }

                this.name = value;
            } 
        }

        public int Age 
        {
            get { return this.age; }
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("The age must be in range [1..100] ");
                }

                this.age = value;
            }
        }

        public string Email 
        {
            get { return this.email; }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (!value.Contains("@"))
                    {
                        throw new ArgumentException("The emai address must not be empty string and it must contains @!");
                    }

                    this.email = value;
                }              
            }
        
        }


        public override string ToString()
        {
            return String.Format("My name is {0} and I'm {1} years old. The emai address is {2}", this.Name, this.Age, this.Email ?? "unknown");
        }
    
    }
}
