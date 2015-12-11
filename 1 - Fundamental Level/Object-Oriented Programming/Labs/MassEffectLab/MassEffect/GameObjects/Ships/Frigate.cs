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
    public class Frigate : StartShip
    {
        private const int BASE_HEALTH = 377;
        private const int BASE_SHIELDS = 300;
        private const int BASE_DAMAGE = 77;
        private const double BASE_FUEL = 333.77;

        private int projectilesFired;

        public Frigate(string name, StarSystem location)
            :base(name, BASE_HEALTH, BASE_SHIELDS, BASE_DAMAGE, BASE_FUEL, location)
        {
            this.ProjectilesFired = 0;
        }

        public int ProjectilesFired 
        {
            get { return this.projectilesFired; }
            set { this.projectilesFired = value; }
        }

        public override IProjectile ProduceAttack()
        {
            ProjectilesFired++;
            return new PenetrationShell(this.Damage);
        }


        public override string ToString()
        {
            return base.ToString() + string.Format("-Projectiles fired: {0}", this.ProjectilesFired);
        }
    }
}
