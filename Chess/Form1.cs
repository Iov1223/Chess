using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            var size = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            var newSize = new Size(size.Width = 738, size.Height = 761);
            this. MinimumSize = this.MaximumSize = this.Size = newSize;
            bool isBlack = false;
            Pen pen = new Pen(Color.Black);
            Brush brushBlack = new SolidBrush(Color.Black);
            Rectangle rect = new Rectangle();
            Graphics gfx = e.Graphics;
            for (int i = 0; i <= 8; i++)
            {
                for (int j = 0; j <= 8; j++)
                {
                    if (i == 0)
                    {
                        rect = new Rectangle(i * 80, j * 80, 80, 80);
                        gfx.DrawRectangle(pen, rect);
                    }
                    else if (j == 0)
                    {
                        rect = new Rectangle(i * 80, j * 80, 80, 80);
                        gfx.DrawRectangle(pen, rect);
                    }
                    else if (isBlack)
                    {
                        rect = new Rectangle(i * 80, j * 80, 80, 80);
                        gfx.DrawRectangle(pen, rect);
                        gfx.FillRectangle(brushBlack, rect);
                        isBlack = false;

                    }
                    else
                    {
                        gfx.DrawRectangle(pen, rect);
                        isBlack = true;
                    }

                }
                isBlack = !isBlack;
            }
        }
    }
}
