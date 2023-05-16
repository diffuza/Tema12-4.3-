using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema12_4._3_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Graphics g;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
            Color cl = Color.FromArgb(255, 255, 255);
            g.Clear(cl);
            int W = ClientRectangle.Width;
            int H = ClientRectangle.Height;
            LinearGradientBrush myBrush = new LinearGradientBrush(
            new Point(0, 0),
            new Point(W, H),
            Color.White,
            Color.Black
            );
            g.FillRectangle(myBrush, ClientRectangle);
            LinearGradientBrush myBrush2 = new LinearGradientBrush(
                new Point(0, 0),
                new Point(W, H),
                 Color.Black,
                 Color.White
               );
            g.FillEllipse(myBrush2, 25, 25, W - 50, H - 50);

            myBrush.Dispose();
            myBrush2.Dispose();

        }

    }
}
