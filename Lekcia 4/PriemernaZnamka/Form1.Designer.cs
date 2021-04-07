
namespace PriemernaZnamka
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMat = new System.Windows.Forms.TextBox();
            this.txtFyz = new System.Windows.Forms.TextBox();
            this.txtChe = new System.Windows.Forms.TextBox();
            this.txtSlo = new System.Windows.Forms.TextBox();
            this.txtAng = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPriemer = new System.Windows.Forms.TextBox();
            this.btnVypocitaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matematika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fyzika";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chémia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Slovenčina";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Angličtina";
            // 
            // txtMat
            // 
            this.txtMat.Location = new System.Drawing.Point(186, 33);
            this.txtMat.Name = "txtMat";
            this.txtMat.Size = new System.Drawing.Size(110, 34);
            this.txtMat.TabIndex = 5;
            // 
            // txtFyz
            // 
            this.txtFyz.Location = new System.Drawing.Point(186, 87);
            this.txtFyz.Name = "txtFyz";
            this.txtFyz.Size = new System.Drawing.Size(110, 34);
            this.txtFyz.TabIndex = 6;
            // 
            // txtChe
            // 
            this.txtChe.Location = new System.Drawing.Point(186, 140);
            this.txtChe.Name = "txtChe";
            this.txtChe.Size = new System.Drawing.Size(110, 34);
            this.txtChe.TabIndex = 7;
            // 
            // txtSlo
            // 
            this.txtSlo.Location = new System.Drawing.Point(186, 204);
            this.txtSlo.Name = "txtSlo";
            this.txtSlo.Size = new System.Drawing.Size(110, 34);
            this.txtSlo.TabIndex = 8;
            // 
            // txtAng
            // 
            this.txtAng.Location = new System.Drawing.Point(186, 272);
            this.txtAng.Name = "txtAng";
            this.txtAng.Size = new System.Drawing.Size(110, 34);
            this.txtAng.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "Priemerná známka";
            // 
            // txtPriemer
            // 
            this.txtPriemer.Location = new System.Drawing.Point(238, 379);
            this.txtPriemer.Name = "txtPriemer";
            this.txtPriemer.Size = new System.Drawing.Size(134, 34);
            this.txtPriemer.TabIndex = 11;
            // 
            // btnVypocitaj
            // 
            this.btnVypocitaj.Location = new System.Drawing.Point(410, 104);
            this.btnVypocitaj.Name = "btnVypocitaj";
            this.btnVypocitaj.Size = new System.Drawing.Size(165, 89);
            this.btnVypocitaj.TabIndex = 12;
            this.btnVypocitaj.Text = "Vypočítaj priemer";
            this.btnVypocitaj.UseVisualStyleBackColor = true;
            this.btnVypocitaj.Click += new System.EventHandler(this.btnVypocitaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVypocitaj);
            this.Controls.Add(this.txtPriemer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAng);
            this.Controls.Add(this.txtSlo);
            this.Controls.Add(this.txtChe);
            this.Controls.Add(this.txtFyz);
            this.Controls.Add(this.txtMat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Výpočet priemernej známky";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMat;
        private System.Windows.Forms.TextBox txtFyz;
        private System.Windows.Forms.TextBox txtChe;
        private System.Windows.Forms.TextBox txtSlo;
        private System.Windows.Forms.TextBox txtAng;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPriemer;
        private System.Windows.Forms.Button btnVypocitaj;
    }
}

