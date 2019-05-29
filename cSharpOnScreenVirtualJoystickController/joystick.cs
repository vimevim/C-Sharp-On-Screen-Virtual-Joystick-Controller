using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpOnScreenVirtualJoystickController
{
    public partial class joystick : Form
    {
        public joystick()
        {
            InitializeComponent();
            this.TransparencyKey = this.BackColor;
            this.Opacity = 0.50; 
        }

        private void joystickArea_Click(object sender, EventArgs e)
        {

        }

        Point mouseDownLocation;
        int cursorOriginX, cursorOriginY;
        int movingPartX, movingPartY;
        double hypotenuse, angle;

        private void joystickArea_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownLocation = e.Location;
                movingPart.Left = movingPartX;
                movingPart.Top = movingPartY;
            }
            this.Opacity = 0.90;
        }
        private void joystickArea_MouseMove(object sender, MouseEventArgs e)
        {
            hypotenuse = Math.Sqrt(cursorOriginX * cursorOriginX + cursorOriginY * cursorOriginY);

            angle = Math.Acos(cursorOriginY / hypotenuse);
            if (cursorOriginX < 0)
            {
                angle = angle * 180 / Math.PI;
            }
            else
            {
                angle -= angle * 180 / Math.PI;
                angle += 360;
            }

            movingPartX = e.X - (movingPart.Width / 2);
            movingPartY = e.Y - (movingPart.Height / 2);
            cursorOriginX = e.X - (joystickArea.Width / 2);
            cursorOriginY = e.Y - (joystickArea.Height / 2);

            if (e.Button == MouseButtons.Left)
            {
                if (hypotenuse < 150)
                {
                    if (cursorOriginX < 125 && cursorOriginX > -125)//x ekseninde 100 ile -100 arasından çıkartmıyor
                    {
                        movingPart.Left = movingPartX;
                    }
                    if (cursorOriginY < 125 && cursorOriginY > -125)//y ekseninde 100 ile -100 arasından çıkartmıyor
                    {
                        movingPart.Top = movingPartY;
                    }
                }
            }
            else
            {
                joystickArea_MouseUp(null, null);
            }
            this.Text = cursorOriginX + " " + cursorOriginY + "   " + movingPartX + " " + movingPartY;
        }

        private void joystickArea_MouseUp(object sender, MouseEventArgs e)
        {
            movingPart.Left = 150;
            movingPart.Top = 150;
            this.Opacity = 0.50;
        }
    }
}
