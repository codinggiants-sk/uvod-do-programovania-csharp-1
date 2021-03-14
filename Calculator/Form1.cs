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
        private Label label2;
        private Label label3;
        private NumericUpDown numericNumber1;
        private NumericUpDown numericNumber2;
        private Button btnAdd;
        private Button btnSubstract;
        private Button btnMultiply;
        private Button btnDivide;
        private Label labelResult;
        private Label label1;

        public Form1()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericNumber1 = new System.Windows.Forms.NumericUpDown();
            this.numericNumber2 = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumber1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumber2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(112, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Číslo 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(112, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Číslo 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(112, 540);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "Výsledok:";
            // 
            // numericNumber1
            // 
            this.numericNumber1.DecimalPlaces = 2;
            this.numericNumber1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericNumber1.Location = new System.Drawing.Point(291, 52);
            this.numericNumber1.Name = "numericNumber1";
            this.numericNumber1.Size = new System.Drawing.Size(180, 47);
            this.numericNumber1.TabIndex = 3;
            // 
            // numericNumber2
            // 
            this.numericNumber2.DecimalPlaces = 2;
            this.numericNumber2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericNumber2.Location = new System.Drawing.Point(291, 138);
            this.numericNumber2.Name = "numericNumber2";
            this.numericNumber2.Size = new System.Drawing.Size(180, 47);
            this.numericNumber2.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(146, 227);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 105);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubstract
            // 
            this.btnSubstract.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubstract.Location = new System.Drawing.Point(310, 227);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(112, 105);
            this.btnSubstract.TabIndex = 6;
            this.btnSubstract.Text = "-";
            this.btnSubstract.UseVisualStyleBackColor = true;
            this.btnSubstract.Click += new System.EventHandler(this.btnSubstract_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMultiply.Location = new System.Drawing.Point(146, 368);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(112, 105);
            this.btnMultiply.TabIndex = 7;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDivide.Location = new System.Drawing.Point(310, 368);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(112, 105);
            this.btnDivide.TabIndex = 8;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.BackColor = System.Drawing.SystemColors.HighlightText;
            this.labelResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelResult.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResult.Location = new System.Drawing.Point(310, 542);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(36, 43);
            this.labelResult.TabIndex = 9;
            this.labelResult.Text = "0";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(584, 651);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubstract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numericNumber2);
            this.Controls.Add(this.numericNumber1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericNumber1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumber2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal number1 = numericNumber1.Value;
            decimal number2 = numericNumber2.Value;
            decimal result = number1 + number2;
            labelResult.Text = result.ToString();
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            decimal number1 = numericNumber1.Value;
            decimal number2 = numericNumber2.Value;
            decimal result = number1 - number2;
            labelResult.Text = result.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            decimal number1 = numericNumber1.Value;
            decimal number2 = numericNumber2.Value;
            decimal result = number1 * number2;
            labelResult.Text = result.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            decimal number1 = numericNumber1.Value;
            decimal number2 = numericNumber2.Value;
            if (number2 != 0)
            {
                decimal result = number1 / number2;
                labelResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Nulou sa nedá deliť!");
            }
        }
    }
}
