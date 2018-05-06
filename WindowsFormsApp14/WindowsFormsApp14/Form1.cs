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

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        Graphics g;
        Pen p;
        GraphicsPath path;
        int x = 0, y = 0, dx = 10, dy = 10;
        string[] color =
        {
            "Red","Blue","Green","Magenta"
        };
        public Form1()
        {
            path = new GraphicsPath();
            InitializeComponent();
            label1.Text = "Score : ";
            label2.Text = "Out :";
            button1.Text = "Start";
            g = CreateGraphics();
            p = new Pen(Color.Red);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            timer1.Start();
            for (int i = 0; i < rnd.Next(10); i++)
            {
                path.AddEllipse( x=rnd.Next(50), y=rnd.Next(50), 5, 5);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
