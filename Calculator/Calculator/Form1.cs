using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            decimal pierwsza = nUDPierwsza.Value;
            decimal druga = nUDDruga.Value;
            decimal wynik = pierwsza + druga;
            txtWynik.Text = wynik.ToString();
        }

        private void btnOdejmij_Click(object sender, EventArgs e)
        {
            decimal pierwsza = nUDPierwsza.Value;
            decimal druga = nUDDruga.Value;
            decimal wynik = pierwsza - druga;
            txtWynik.Text = wynik.ToString();
        }

        private void btnPomnoz_Click(object sender, EventArgs e)
        {
            decimal pierwsza = nUDPierwsza.Value;
            decimal druga = nUDDruga.Value;
            decimal wynik = pierwsza * druga;
            txtWynik.Text = wynik.ToString();
        }

        private void btnPodziel_Click(object sender, EventArgs e)
        {
            decimal pierwsza = nUDPierwsza.Value;
            decimal druga = nUDDruga.Value;
            if (druga != 0)
            {
                decimal wynik = pierwsza/druga;
                txtWynik.Text = wynik.ToString();
            }
            else
            {
                MessageBox.Show("Nie dziel przez zero!");
            }
        }
    }
}
