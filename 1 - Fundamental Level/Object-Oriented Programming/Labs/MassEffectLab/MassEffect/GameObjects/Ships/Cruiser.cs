using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MassEffect.GameObjects.Locations;
using MassEffect.Interfaces;
using MassEffect.GameObjects.Projectiles;

namespace MassEffect.GameObjects.Ships
{
    public class Cruiser : StartShip
    {
        private const int BASE_HEALTH = 377;
        private const int BASE_SHIELDS = 300;
        private const int BASE_DAMAGE = 77;
        private const double BASE_FUEL = 333.77;

        public Cruiser(string name, StarSystem location)
            :base(name, BASE_HEALTH, BASE_SHIELDS, BASE_DAMAGE, BASE_FUEL, location)
        {

        }

        public override IProjectile ProduceAttack()
        {
            return new ShieldReaver(this.Damage);
        }
    }
}
