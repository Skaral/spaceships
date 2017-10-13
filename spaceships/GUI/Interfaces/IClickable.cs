using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spaceships.GUI.Interfaces
{
    interface IClickable
    {
        void Click(object sender, MouseEventArgs e);
        void DoubleClick(object sender, MouseEventArgs e);
    }
}
