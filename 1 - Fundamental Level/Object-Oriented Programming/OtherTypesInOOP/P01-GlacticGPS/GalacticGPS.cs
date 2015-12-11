using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_GlacticGPS
{
    public class GalacticGps
    {
        public static void Main(string[] args)
        {
            try
            {
                Location home = new Location(17.37337, 3.77377, Planet.Earth);
                Console.WriteLine(home);
            }
            catch (ArgumentOutOfRangeException e)
            {

                Console.WriteLine(e.Message);
            }
        }
       
        
    }
}
