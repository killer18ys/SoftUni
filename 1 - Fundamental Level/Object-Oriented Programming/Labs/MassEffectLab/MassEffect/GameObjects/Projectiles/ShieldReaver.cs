using MassEffect.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassEffect.GameObjects.Projectiles
{
    public class ShieldReaver : IProjectile
    {
        public ShieldReaver(int damage)
        {
            this.Damage = damage;
        }

        public int Damage { get; set; }

        public void Hit(IStarship targetShip)
        {
            targetShip.Health -= this.Damage;
            targetShip.Shields -= this.Damage * 2;
        }
    }
}
