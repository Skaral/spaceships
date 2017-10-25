using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spaceships.GameObjects.SpaceShip.Components
{
    class Component                                 // Komponenta lodi
    {
        public String Name { get; set; }            // Jméno

        public int Size { get; set; }               // Velikost
        public int Mass { get; set; }               // Hmotnost
        public int Hp   { get; set; }               // Životy
       
        // ----- Power -----
        public int Pwr_Consuption { get; set; }     // Spotřeba
        public int Pwr_Capacity   { get; set; }     // Kapacita
        public int Pwr_Current    { get; set; }     // Aktuální stav

        public Component()
        {
            this.Name = "unnamed_component";
            Console.WriteLine("Ship component has been created.");
        }

        public bool Activate()
        {
            if (this.Pwr_Current >= Pwr_Consuption) // Dostatek energie
            {
                Console.WriteLine("Activation of {0} was succesfull", this.ToString());
                return true;
            }
            else                                    // Nedostatek energie
            {
                Console.WriteLine("Activation of {0} was unsuccesfull", this.ToString());
                return false;
            }
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
