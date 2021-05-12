using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrepocetKmNaMile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrepocitaj_Click(object sender, EventArgs e)
        {
            const float prevodMile = 1.609f;
            float KM = float.Parse(txtKM.Text);
            float Mile = KM / prevodMile;
            txtMile.Text =  Mile.ToString();

        }
    }
}
