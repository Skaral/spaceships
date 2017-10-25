using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using spaceships.GameObjects.SpaceShip;
using spaceships.GameObjects.SpaceShip.Components.Weapons;

namespace spaceships
{
    static class Program
    {
        /// <summary>
        /// Hlavní vstupní bod aplikace.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SpaceShip s = new SpaceShip();
            Weapon w = new Weapon();
            w.Shoot(s);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
