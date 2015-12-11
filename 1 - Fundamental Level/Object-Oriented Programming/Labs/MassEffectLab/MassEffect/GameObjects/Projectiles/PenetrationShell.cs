using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MassEffect.Interfaces; 

namespace MassEffect.GameObjects.Projectiles
{
    public class PenetrationShell : Projectiles
    {
        public PenetrationShell(int damage)
            :base(damage)
        {

        }

        public override void Hit(IStarship targetShip)
        {
            targetShip.Health -= this.Damage;
        }
    }
}
