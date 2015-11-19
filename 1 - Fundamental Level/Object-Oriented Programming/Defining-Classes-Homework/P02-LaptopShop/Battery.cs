using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_LaptopShop
{
    class Battery
    {
        private string batteryType;
        private double batteryLife;


        public Battery(string batteryType, double batteryLife)
        {
            this.BatteryType = batteryType;
            this.BatteryLife = batteryLife;
        }

        public Battery(string batteryType) 
            :this(batteryType, 0)
        {
            
        }

        public string BatteryType
        {
            get { return this.batteryType;}

            set
            {
                if (string.IsNullOrEmpty(value))
	            {
		            throw new ArgumentException("Battery type is null or empty!");
	            }
                this.batteryType = value;
            }
        }

        public double BatteryLife
        {
            get { return this.batteryLife;}
            set 
            {
                if (value < 0)
	            {
		            throw new ArgumentOutOfRangeException("Battery life cannot be negative nnumber!");
	            }
                this.batteryLife = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            if (this.batteryType != null)
            {
                result.Append("Battery type: ").AppendLine(this.BatteryType);   
            }
            
            if (this.BatteryLife > 0)
            {
                result.Append("Battery life: ").Append(this.BatteryLife).AppendLine(" hours");
            }

 	        return result.ToString();
        }
    }
}
