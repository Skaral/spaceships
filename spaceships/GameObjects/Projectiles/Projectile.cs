using spaceships.GameObjects.SpaceShip.Components.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spaceships.GameObjects.Projectiles
{
    class Projectile : GameObject
    {
        public WeaponType ProjectileType { get; set; }
        // ----- Poškození -----
        public int Dmg_Physical   { get; set; }
        public int Dmg_Explosive  { get; set; }
        public int Dmg_Thermal    { get; set; }
        public int Dmg_Energy     { get; set; }
        public int Dmg_Distortion { get; set; }

        public Projectile(WeaponType projectileType,
            int dmg_Physical, int dmg_Explosive, 
            int dmg_Thermal, int dmg_Energy, 
            int dmg_Distortion)
        {
            this.Name = "unnamed_projectile";
            Console.WriteLine("Projectile has been created.");

            // ----- Damage -----
            ProjectileType = projectileType;
            Dmg_Physical   = dmg_Physical;
            Dmg_Explosive  = dmg_Explosive;
            Dmg_Thermal    = dmg_Thermal;
            Dmg_Energy     = dmg_Energy;
            Dmg_Distortion = dmg_Distortion;
        }
    }
}
