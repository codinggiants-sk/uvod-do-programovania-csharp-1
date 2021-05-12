using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KamenPapierNoznice
{
    public partial class Form1 : Form
    {
        int MojaVolba;
        int Volba;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnLosuj_Click(object sender, EventArgs e)
        {
            Random R = new Random();
            Volba = R.Next(1, 4);
            string VolbaPC;
            switch (Volba)
            {
                case 1:
                    txtVolbaPC.Text = "Kameň";
                    VolbaPC = "Kameň";
                    break;
                case 2:
                    txtVolbaPC.Text = "Papier";
                    VolbaPC = "Papier";
                    break;
                case 3:
                    txtVolbaPC.Text = "Nožnice";
                    VolbaPC = "Nožnice";
                    break;
                default:
                    txtVolbaPC.Text = Volba.ToString();
                    break;
            }
        }

        private void btnVyhodnotenie_Click(object sender, EventArgs e)
        {
            if (Volba==MojaVolba)
            {
                MessageBox.Show("Remíza");
            }
            else if (Volba==1 && MojaVolba==2)
            {
                MessageBox.Show("Výhra Ty");
            }
            else if (Volba == 1 && MojaVolba == 3)
            {
                MessageBox.Show("Výhra PC");
            }
            else if (Volba == 2 && MojaVolba == 1)
            {
                MessageBox.Show("Výhra PC");
            }
            else if (Volba == 2 && MojaVolba == 3)
            {
                MessageBox.Show("Výhra Ty");
            }
            else if (Volba == 3 && MojaVolba == 1)
            {
                MessageBox.Show("Výhra Ty");
            }
            else if (Volba == 3 && MojaVolba == 2)
            {
                MessageBox.Show("Výhra PC");
            }

        }

        private void rdbKamen_CheckedChanged(object sender, EventArgs e)
        {
            MojaVolba = 1;
        }

        private void rdbPapier_CheckedChanged(object sender, EventArgs e)
        {
            MojaVolba = 2;
        }

        private void rdbNoznice_CheckedChanged(object sender, EventArgs e)
        {
            MojaVolba = 3;
        }
    }
}
