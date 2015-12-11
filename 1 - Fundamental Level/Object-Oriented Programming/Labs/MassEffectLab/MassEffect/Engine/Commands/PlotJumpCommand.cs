using System;
using System.Linq;

namespace MassEffect.Engine.Commands
{
    using MassEffect.GameObjects.Locations;
    using MassEffect.Interfaces;
    using MassEffect.Exceptions;

    public class PlotJumpCommand : Command
    {
        public PlotJumpCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            string shipName = commandArgs[1];
            string destinationName = commandArgs[2];

            IStarship ship = this.GameEngine.Starships.First(s => s.Name == shipName);

            this.ValidateAlive(ship);

            var priviousLocation = ship.Location;
            StarSystem destination = this.GameEngine.Galaxy.GetStarSystemByName(destinationName);

            if (priviousLocation.Name == destinationName)
            {
                throw new ShipException(string.Format(Messages.ShipAlreadyInStarSystem, destinationName));
            }

            this.GameEngine.Galaxy.TravelTo(ship, destination);

            Console.WriteLine(Messages.ShipTraveled, shipName, priviousLocation.Name, destinationName);

        }
    }
}
