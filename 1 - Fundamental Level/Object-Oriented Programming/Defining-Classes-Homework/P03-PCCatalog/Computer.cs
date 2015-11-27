using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P03_PCCatalog.Components;

namespace P03_PCCatalog
{
    public class Computer
    {
        //name, several components and price
        private string name;
        private List<Component> components = new List<Component>();
        private double price;


        public Computer(string name)
        {
            this.Name = name;
            this.components = new List<Component>();
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

        public IEnumerable<Component> Components
        {
            get { return components; }
        }

        public void AddComponent(Component component)
        {
            if (this.components.Contains(component))
            {
                throw new InvalidOperationException("This component already exists!");
            }

            components.Add(component);
            this.Price += component.Price;
        }


        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.Append("-Name: ").AppendLine(this.Name);

            str.AppendLine("Components: ");


            foreach (var component in components)
            {
                str.AppendFormat("  -{0,-15} {1,-10} {2} lv\n", component.GetType().Name, component.Name, component.Price);
            }
            str.Append("-Price: ").AppendLine(this.Price.ToString() + " lv");

            return str.ToString();
        }
    }
}
