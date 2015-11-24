using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_LaptopShop
{
    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private string ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private Battery battery;   
        private decimal price;


        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }

        public Laptop(string model, decimal price, string manufacturer = null, string processor = null, string ram = null,
            string hdd = null, string graphicsCard = null, Battery battery = null, string screen = null )
            :this(model, price)
        {
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.Hdd = hdd;
            this.Screen = screen;
            this.Battery = battery;
        }


        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The model field cannot be null or empty string!");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (value != null && value.Length <= 0){
                    throw new ArgumentException("The manufacturer field cannot be empty string");
                }
                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get { return this.processor; }

            set
            {
                if (value != null && value.Length <= 0)
                {
                    throw new ArgumentException("The prossesor field cannot be empty string!");
                }
                this.processor = value;
            }
        }

        public string Ram
        {
            get { return this.ram; }
            set
            {
                if(value != null && value.Length <= 0){
                    throw new ArgumentException("The ram field cannot be empty string!");
                }
                this.ram = value;
            }

        }

        public string GraphicsCard
        {
            get { return this.graphicsCard; }
            set
            {
                if (value != null && value.Length <= 0)
                {
                    throw new ArgumentException("The grafic card field cannot be empty string!");
                }
                this.graphicsCard = value;

            }
        }

        public string Screen
        {
            get { return this.screen; }
            set
            {
                if (value != null && value.Length <= 0)
                {
                    throw new ArgumentException("The screen field cannot be empty string!");
                }
                this.screen = value;

            }
        }

        public string  Hdd 
        {
            get { return this.hdd; }
            set
            {
                if (value != null && value.Length <= 0)
                {
                    throw new ArgumentException("The hdd filed cannot be empty string!");
                }
                this.hdd = value;
            }
        }

        public Battery Battery 
        { 
            get {return this.battery;}
            set { this.battery = value; }
        }

        public decimal Price
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

            result.Append("Model: ").AppendLine(this.Model);

            result.Append("Price: ").Append(this.Price).AppendLine(" lv");

            if (this.Manufacturer != null)
            {
                result.Append("Manufacturer: ").AppendLine(this.Manufacturer);
            }

            if (this.Processor != null) 
            {
                result.Append("Processor: ").AppendLine(this.Processor);                
            }

            if (this.Ram != null)
            {
                result.Append("Ram: ").AppendLine(this.Ram);
            }

            if (this.Hdd != null)
            {
                result.Append("Hdd: ").AppendLine(this.Hdd);
            }

            if (this.Battery != null)
            {
                result.Append(this.Battery.ToString());
            }

            if (this.Screen != null)
            {
                result.Append("Screen: ").AppendLine(this.Screen);
            }

            return result.ToString();
        }

    }
} 