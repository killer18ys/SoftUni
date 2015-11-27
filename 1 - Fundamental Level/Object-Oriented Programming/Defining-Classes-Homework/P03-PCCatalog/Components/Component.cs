using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_PCCatalog.Components
{
    public abstract class Component
    {
        private string name;
        private double price;
        private string details;


        public Component(string name, double price, string details = null)
        {
            this.Name = name;
            this.Price = price;
            this.Details = details;
        }

        public String Name
        {
            get{ return this.name;}
            set
            {
                if (string.IsNullOrEmpty(value))
	            {
	                throw new ArgumentException("Name cannot be empty string!");
	            }
                this.name = value;

            }
        }

        public double Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative number!");
                }
                this.price = value;
            }
        }

        public String Details
        {
            get { return this.details; }
            set
            {
                if (value != null && value.Length < 0)
                {
                    throw new ArgumentException("Details cannot be empty string!");
                }
                this.details = value;

            }
        }
    }
}
