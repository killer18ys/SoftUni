using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_FourFactors
{
    class FourFactors
    {
        static void Main(string[] args)
        {
            uint fg = uint.Parse(Console.ReadLine());
            uint fga = uint.Parse(Console.ReadLine());
            uint _3p = uint.Parse(Console.ReadLine());
            uint tov = uint.Parse(Console.ReadLine());
            uint orb = uint.Parse(Console.ReadLine());
            uint oppDrb = uint.Parse(Console.ReadLine());
            uint ft = uint.Parse(Console.ReadLine());
            uint fta = uint.Parse(Console.ReadLine());
        
        
            double eFGResult;
            double TOVResult;
            double ORBResult;
            double FTResult;


            eFGResult = (fg + 0.5 * _3p)/fga;

            TOVResult = (tov / (fga + 0.44 * fta + tov));

            ORBResult = (orb / (double)(orb + oppDrb));

            FTResult = (ft / (double)fga);

            Console.WriteLine("eFG% {0:F3}", eFGResult);
            Console.WriteLine("TOV% {0:F3}", TOVResult);
            Console.WriteLine("ORB% {0:F3}", ORBResult);
            Console.WriteLine("FT% {0:F3}", FTResult);
        
        }
    }
}
