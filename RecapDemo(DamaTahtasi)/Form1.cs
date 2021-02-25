using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo_DamaTahtasi_
{
    public partial class Form1 : Form//inheritance
    {
        public Form1()//constructor
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[ , ] buttons = new Button[8,8];//Marix olarak tahyyüel edebilirim.
            int top = 0;
            int left = 0;
            for (int i = 0; i <= buttons.GetUpperBound(0); i++)//getupperbound(0) 0.boyutun alabileceği en buyuk degerer tekabul eder o da = 7
            {
                for (int j = 0; j <= buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();//her butanı yeni birbuton olara new'leyiyoruz.
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    left += 50;
                    buttons[i,j].Top = top;
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                        buttons[i, j].Text = "Siyah";
                        buttons[i, j].ForeColor = Color.White;

                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                        buttons[i, j].Text = "Beyaz";
                        buttons[i, j].ForeColor = Color.Black;
                    }
                    this.Controls.Add(buttons[i, j]);

                }
                top += 50;
                left = 0;
            }
        }
    }
}
