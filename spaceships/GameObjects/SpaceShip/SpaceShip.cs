using spaceships.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace spaceships.GameObjects.SpaceShip
{
    class SpaceShip : GameObject                // Vesmírná loď
    {
        public int Health { get; set; }         // Životy

        public SpaceShip() : base()
        {
            this.Name = "unnamed_space_ship";
            Console.WriteLine("Space_ship has been created.");
        }
    }
}
