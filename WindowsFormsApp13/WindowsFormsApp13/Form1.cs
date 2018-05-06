using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        List<Button> game = new List<Button>();
        int cnt = 1, a = 0, b = 0, x = 1, y = 1;

        private void timer1_Tick(object sender, EventArgs e)
        {

            for (int i = 1; i <= 8; i = i + 3)
                if (game[i].Text == game[i + 1].Text && game[i + 1].Text == game[i + 2].Text && game[i].Text != "" && game[i + 1].Text != "" && game[i + 2].Text != "") { timer1.Stop(); MessageBox.Show("GameOver");}
            for (int i = 1; i <= 3; i++)
                if (game[i].Text == game[i + 3].Text && game[i + 3].Text == game[i + 6].Text && game[i].Text != "" && game[i + 3].Text != "" && game[i + 6].Text != "") { timer1.Stop(); MessageBox.Show("GameOver");}
            if (game[1].Text == game[5].Text && game[5].Text == game[9].Text && game[1].Text != "" && game[5].Text != "" && game[9].Text != "") { timer1.Stop(); MessageBox.Show("GameOver");}
            else if (game[3].Text == game[5].Text && game[5].Text == game[7].Text && game[1].Text != "" && game[3].Text != "" && game[5].Text != "" && game[7].Text != "") { timer1.Stop(); MessageBox.Show("GameOver"); }
        }

        private void buttons_Clicked(object sender, EventArgs e)
        {
            Button game = sender as Button;
            {

                if (cnt % 2 == 0) { game.Text = "O"; cnt++; game.Enabled = false; }
                else { game.Text = "X"; cnt++; game.Enabled = false; }
            }
        }

        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=0; i<=9; i++)
            {
                game.Add(new Button());
            }
            timer1.Start();
                for (int j = 1; j <=9; j++)
                {
                    game[j].Name = "button" + cnt;
                    game[j].Text = "";
                    game[j].Location = new Point(x, y);
                    game[j].Width = 50;
                    game[j].Height = 50;
                    game[j].Click += new System.EventHandler(buttons_Clicked);
                Controls.Add(game[j]);
                    cnt++;
                    x = x + 60;
                if (j % 3 == 0)
                { y = y + 60; x = 1; }
                }
            cnt = 1;
        }
    }
}
