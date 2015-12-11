using MassEffect.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassEffect.GameObjects.Projectiles
{
    public class Laser : IProjectile
    {
        public Laser(int damage)
        {
            this.Damage = damage;
        }

        public int Damage { get; set; }
        
        public void Hit(IStarship targetShip)
        {
            if (targetShip.Shields < this.Damage )
            {
                int damageLeft = this.Damage - targetShip.Shields;
                targetShip.Shields -= this.Damage;
                targetShip.Health -= damageLeft;
            }
            else
            {
                targetShip.Shields -= this.Damage;
            }
        }
    }
}
