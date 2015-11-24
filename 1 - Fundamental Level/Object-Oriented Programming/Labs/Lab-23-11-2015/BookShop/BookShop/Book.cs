using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    public class Book
    {
        private string title;
        private string author;
        private double price;


        public Book(string title, string author, double price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public string Title 
        {
            get { return this.title; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Title cannot be null or empty!");
                }
                this.title = value;
            }
        }

        public string Author 
        {
            get { return this.author; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Title cannot be null or empty!");
                }
                this.author = value;
            }
        }

        public virtual double Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The price cannot be negative number!");
                }
                this.price = value;
            }
        }


        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append("-Type: ").AppendLine(this.GetType().Name);
            result.Append("-Title: ").AppendLine(this.Title);
            result.Append("-Author: ").AppendLine(this.Author);
            result.Append("-Price: ").AppendLine(this.Price.ToString());

            return result.ToString();
        }

    }
}
