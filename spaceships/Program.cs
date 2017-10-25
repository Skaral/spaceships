using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using spaceships.GameObjects.SpaceShip;
using spaceships.GameObjects.SpaceShip.Components.Weapons;
using spaceships.GameObjects.SpaceShip.Components.Defence.Armor;

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
            s.Health = 500;
            s.Armor = new Armor(
                ArmorType.simple,
                20, 0, 0, 0, 0
                );

            Weapon w = new Weapon();
            w.Dmg_Physical = 25;
            w.Shoot(s);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
