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
        public String Name { get; set; }       // Jméno objektu
        public String Size { get; set; }       // Velikost objektu
        public Point  Pos  { get; set; }       // Pozice objektu
        public Vector Vec  { get; set; }       // Směrový vektor

        public GameObject()
        {
            this.Name = "unnamed_game_object";
            Console.WriteLine("GameObject has been created.");
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
