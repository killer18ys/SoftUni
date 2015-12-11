using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_GlacticGPS
{
    public struct Location
    {
        private double latitude;
        private double longitude;

        public Location(double latitude, double longitude, Planet planet)
            :this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Planet = planet;
        }

        public double Latitude
        {
            get { return latitude; }
            set
            {
                if (value < -90 || value > 90)
                {
                    throw new ArgumentOutOfRangeException("The range of latitude is -90/+90");
                }
                this.latitude = value;
            }
        }

        public double Longitude
        {
            get { return longitude;}
            set
            {
                if (value < -180 || value > 180)
                {
                    throw new ArgumentOutOfRangeException("The range of longitude is -180/+180!");
                }
                this.longitude = value;
            }
        }

        public Planet Planet { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} - {2}", this.Latitude, this.Longitude, this.Planet);
        }
    }
}
