using System;
using System.Linq;

namespace MassEffect.Engine.Commands
{
    using MassEffect.Exceptions;
    using MassEffect.Interfaces;

    public class AttackCommand : Command
    {
        public AttackCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {

        }

        public override void Execute(string[] commandArgs)
        {
            string attackerName = commandArgs[1];
            string targetName = commandArgs[2];

            IStarship attackerShip = this.GameEngine.Starships.First(s => s.Name == attackerName);
            IStarship targetShip = this.GameEngine.Starships.First(s => s.Name == targetName);

            this.ProcessStarshipBattle(attackerShip, targetShip);
        }

        private void ProcessStarshipBattle(IStarship attackerShip, IStarship targetShip)
        {
            base.ValidateAlive(attackerShip);
            base.ValidateAlive(targetShip);

            if (!attackerShip.Location.Equals(targetShip.Location))
            {
                throw new LocationOutOfRangeException("Attacker and target ship must be in the same StarSystem!");
            }

            IProjectile attack = attackerShip.ProduceAttack();
            targetShip.RespondToAttack(attack);

            Console.WriteLine(Messages.ShipAttacked, attackerShip.Name, targetShip.Name);

            if (targetShip.Shields < 0)
            {
                targetShip.Shields = 0;
            }

            if (targetShip.Health <= 0 )
            {
                targetShip.Health = 0;
                Console.WriteLine(Messages.ShipDestroyed, targetShip.Name);
            }
            
        }



    }
}
