using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_ButtonGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поздравляем! Вы смогли нажать на кнопку!");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Point cur = button1.Parent.PointToClient(Cursor.Position);
            Point loc = button1.Location;
            int x_new = loc.X;
            int y_new = loc.Y;
            if (cur.X < loc.X + 10)
                x_new += 10;
            if (cur.X + 10 > loc.X + button1.Width) x_new += -10;
            if (x_new < 20) x_new = 20;
            if (x_new > button1.Parent.Width - button1.Width - 20) x_new = button1.Parent.Width - button1.Width - 20;
            if (cur.Y < loc.Y + 10)
                y_new += 10;
            if (cur.Y + 10 > loc.Y + button1.Height) y_new += -10;
            if (y_new < 20) y_new = 20;
            if (y_new > button1.Parent.Height - button1.Height - 20) y_new = button1.Parent.Height - button1.Height - 20;
            button1.Location = new Point(x_new, y_new);
        }

        
    }
}
