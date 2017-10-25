using spaceships.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using spaceships.GameObjects.Projectiles;
using spaceships.GameObjects.SpaceShip.Components.Defence.Armor;

namespace spaceships.GameObjects.SpaceShip
{
    class SpaceShip : GameObject                // Vesmírná loď
    {
        public Armor Armor { get; set; }
        public SpaceShip() : base()
        {
            this.Name = "unnamed_space_ship";
            Console.WriteLine("Space_ship has been created.");
        }
        public override void TakeHit(Projectile p)
        {
            int TotalDamage;
            if (Armor != null)
                TotalDamage =
                      p.Dmg_Physical  * (100 - Armor.Red_Physical)  / 100
                    + p.Dmg_Explosive * (100 - Armor.Red_Explosive) / 100
                    + p.Dmg_Thermal   * (100 - Armor.Red_Thermal)   / 100
                    + p.Dmg_Energy    * (100 - Armor.Red_Energy)    / 100;
            else
                TotalDamage = p.Dmg_Physical + p.Dmg_Explosive + p.Dmg_Thermal + p.Dmg_Energy;
            this.Health -= TotalDamage;
            Console.WriteLine("{0} has taken {1} points of damage", this.ToString(), TotalDamage);
        }
    }
}
