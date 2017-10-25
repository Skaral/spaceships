using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spaceships.GameObjects.SpaceShip.Components.Defence.Armor
{
    class Armor : Component
    {
        public ArmorType ArmorType { get; set; }
        // ----- Redukce poškození -----
        public int Red_Physical   { get; set; }
        public int Red_Explosive  { get; set; }
        public int Red_Thermal    { get; set; }
        public int Red_Energy     { get; set; }
        public int Red_Distortion { get; set; }

        public Armor(ArmorType armorType, 
            int red_Physical, int red_Explosive, 
            int red_Thermal, int red_Energy, 
            int red_Distortion)
        {
            this.Name = "unnamed_armor";
            Console.WriteLine("Ship armor has been created");

            ArmorType      = armorType;
            Red_Physical   = red_Physical;
            Red_Explosive  = red_Explosive;
            Red_Thermal    = red_Thermal;
            Red_Energy     = red_Energy;
            Red_Distortion = red_Distortion;
        }
    }
    enum ArmorType
    {
        simple,
        reinforced,
        composite,
        refraction
    }
}
