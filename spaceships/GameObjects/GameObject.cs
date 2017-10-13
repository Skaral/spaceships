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
        public Point Pos { get; set; }         // Pozice objektu
        public Vector Vec { get; set; }        // Směrový vektor
    }
}
