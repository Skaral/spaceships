using spaceships.GameObjects.Projectiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace spaceships.GameObjects
{
    class GameObject                           // Objekt herního světa
    {
        public int Health { get; set; }        // Životy

        public String Name { get; set; }       // Jméno objektu
        public String Size { get; set; }       // Velikost objektu
        public Point  Pos  { get; set; }       // Pozice objektu
        public Vector Vec  { get; set; }       // Směrový vektor

        public GameObject()
        {
            this.Name = "unnamed_game_object";
            Console.WriteLine("GameObject has been created.");
        }

        virtual public void TakeHit(Projectile p)
        {
            int TotalDamage = p.Dmg_Physical + p.Dmg_Explosive + p.Dmg_Thermal + p.Dmg_Energy;  // Distortion jen pro štíty
            this.Health -= TotalDamage;
            Console.WriteLine("{0} has taken {1} points of damage", this.ToString(), TotalDamage);
        }
         
        public override string ToString()
        {
            return Name;
        }
    }
}
