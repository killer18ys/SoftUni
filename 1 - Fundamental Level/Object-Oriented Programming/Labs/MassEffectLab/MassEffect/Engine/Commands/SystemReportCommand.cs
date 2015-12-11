using MassEffect.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassEffect.Engine.Commands
{
    public class SystemReportCommand : Command
    {
        public SystemReportCommand(IGameEngine gameEngine)
            :base(gameEngine)
        {

        }

        public override void Execute(string[] commandArgs)
        {
            string starSystem = commandArgs[1];

            IEnumerable<IStarship> intactShip = this.GameEngine.Starships
                .Where(s => s.Location.Name == starSystem && s.Health > 0)
                .OrderBy(s => s.Health)
                .ThenBy(s => s.Shields);

            StringBuilder output = new StringBuilder();

            output.AppendLine("Intact ships:");
            output.AppendLine(intactShip.Any() ?
                string.Join("\n", intactShip) : "N/A");

            IEnumerable<IStarship> destroyedShips = this.GameEngine.Starships
                .Where(s => s.Location.Name == starSystem && s.Health <= 0)
                .OrderBy(s => s.Name);

            output.AppendLine("Destroyed ships:");
            output.AppendLine(destroyedShips.Any() ?
                string.Join("\n", destroyedShips) : "N/A");

            Console.WriteLine(output.ToString());

        }
    }
}
