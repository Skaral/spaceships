using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spaceships.GameObjects.SpaceShip.Components.Weapons
{
    class Weapon : Component            // Zbraň na loď
    {
        public int Fire_rate { get; set; }

        public WeaponType WeaponType { get; set; }
        // ----- Poškození -----
        public int Dmg_Physical     { get; set; }
        public int Dmg_Explosive    { get; set; }
        public int Dmg_Thermal      { get; set; }
        public int Dmg_Energy       { get; set; }
        public int Dmg_Distortion   { get; set; }

        public Weapon() : base()
        {
            this.Name = "unnamed_weapon";
            Console.WriteLine("Ship weapon has been created");
        }

        public void Shoot()
        {
            this.Activate();
            Console.WriteLine("Pew! Pew!");
        }
        public void Shoot(GameObject g)
        {
            this.Activate();
            Console.WriteLine("Shooting on {0}. Pew! Pew!", g.ToString());
        }
    }
    enum WeaponType
    {
        Kinetic,
        Explosive,
        Laser,
        Energy
    }
}
