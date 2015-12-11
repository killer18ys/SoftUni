using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MassEffect.GameObjects.Locations;
using MassEffect.GameObjects.Projectiles;
using MassEffect.Interfaces;

namespace MassEffect.GameObjects.Ships
{
    public class Dreadnought : StartShip
    {   
        private const int BASE_HEALTH = 377;
        private const int BASE_SHIELDS = 300;
        private const int BASE_DAMAGE = 77;
        private const double BASE_FUEL = 333.77;

        public Dreadnought(string name, StarSystem location)
            :base(name, BASE_HEALTH, BASE_SHIELDS, BASE_DAMAGE, BASE_FUEL, location)
        {

        }

        public override IProjectile ProduceAttack()
        {
            return new Laser(this.Damage + this.Shields / 2);
        }

        public override void RespondToAttack(IProjectile projectile)
        {
            this.Shields += 50;
            projectile.Hit(this);
            this.Shields -= 50;

        }
    }
}
