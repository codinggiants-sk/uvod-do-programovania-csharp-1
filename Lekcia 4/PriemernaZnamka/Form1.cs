using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriemernaZnamka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVypocitaj_Click(object sender, EventArgs e)
        {
            int Mat = int.Parse(txtMat.Text);
            int Fyz = int.Parse(txtFyz.Text);
            int Ch = int.Parse(txtChe.Text);
            int Slo = int.Parse(txtSlo.Text);
            int Ang = int.Parse(txtAng.Text);
            float Priemer =(float) (Mat + Fyz + Ch + Slo + Ang) / 5;
            txtPriemer.Text = Priemer.ToString();
        }
    }
}
