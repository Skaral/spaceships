using spaceships.GUI.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spaceships.GUI
{

    abstract class Component : IDrawable, IClickable
    {
        public event EventHandler OnClickOn;
        public event EventHandler OnDoubleClick;
        public event EventHandler OnChange;
        public int posX { get; set; }
        public int posY { get; set; }

        abstract public void Draw(Graphics g);
        virtual public void Click(object sender, MouseEventArgs e)
        {
            RaiseClickOnEvent(this, EventArgs.Empty);
        }
        virtual public void DoubleClick(object sender, MouseEventArgs e)
        {
            RaiseDoubleClickOnEvent(this, EventArgs.Empty);
        }

        virtual protected void RaiseDoubleClickOnEvent(object sender, EventArgs e)
        {
            this.OnDoubleClick?.Invoke(this, e);
        }
        virtual protected void RaiseClickOnEvent(object sender, EventArgs e)
        {
            this.OnClickOn?.Invoke(this, e);
        }
        virtual protected void RaiseOnChangeEvent(object sender, EventArgs e)
        {
            this.OnChange?.Invoke(this, e);
        }
    }
}
