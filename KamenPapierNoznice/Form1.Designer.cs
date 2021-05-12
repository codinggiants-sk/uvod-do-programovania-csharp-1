
namespace KamenPapierNoznice
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbNoznice = new System.Windows.Forms.RadioButton();
            this.rdbPapier = new System.Windows.Forms.RadioButton();
            this.rdbKamen = new System.Windows.Forms.RadioButton();
            this.txtVolbaPC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLosuj = new System.Windows.Forms.Button();
            this.btnVyhodnotenie = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbNoznice);
            this.groupBox1.Controls.Add(this.rdbPapier);
            this.groupBox1.Controls.Add(this.rdbKamen);
            this.groupBox1.Location = new System.Drawing.Point(58, 84);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(204, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tvoja volba";
            // 
            // rdbNoznice
            // 
            this.rdbNoznice.AutoSize = true;
            this.rdbNoznice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbNoznice.Location = new System.Drawing.Point(22, 145);
            this.rdbNoznice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbNoznice.Name = "rdbNoznice";
            this.rdbNoznice.Size = new System.Drawing.Size(84, 25);
            this.rdbNoznice.TabIndex = 2;
            this.rdbNoznice.TabStop = true;
            this.rdbNoznice.Text = "Nožnice";
            this.rdbNoznice.UseVisualStyleBackColor = true;
            this.rdbNoznice.CheckedChanged += new System.EventHandler(this.rdbNoznice_CheckedChanged);
            // 
            // rdbPapier
            // 
            this.rdbPapier.AutoSize = true;
            this.rdbPapier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbPapier.Location = new System.Drawing.Point(22, 97);
            this.rdbPapier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbPapier.Name = "rdbPapier";
            this.rdbPapier.Size = new System.Drawing.Size(71, 25);
            this.rdbPapier.TabIndex = 1;
            this.rdbPapier.TabStop = true;
            this.rdbPapier.Text = "Papier";
            this.rdbPapier.UseVisualStyleBackColor = true;
            this.rdbPapier.CheckedChanged += new System.EventHandler(this.rdbPapier_CheckedChanged);
            // 
            // rdbKamen
            // 
            this.rdbKamen.AutoSize = true;
            this.rdbKamen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbKamen.Location = new System.Drawing.Point(22, 49);
            this.rdbKamen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbKamen.Name = "rdbKamen";
            this.rdbKamen.Size = new System.Drawing.Size(76, 25);
            this.rdbKamen.TabIndex = 0;
            this.rdbKamen.TabStop = true;
            this.rdbKamen.Text = "Kameň";
            this.rdbKamen.UseVisualStyleBackColor = true;
            this.rdbKamen.CheckedChanged += new System.EventHandler(this.rdbKamen_CheckedChanged);
            // 
            // txtVolbaPC
            // 
            this.txtVolbaPC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVolbaPC.Location = new System.Drawing.Point(297, 225);
            this.txtVolbaPC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVolbaPC.Name = "txtVolbaPC";
            this.txtVolbaPC.Size = new System.Drawing.Size(179, 29);
            this.txtVolbaPC.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(297, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Volba počítač";
            // 
            // btnLosuj
            // 
            this.btnLosuj.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLosuj.Location = new System.Drawing.Point(297, 95);
            this.btnLosuj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLosuj.Name = "btnLosuj";
            this.btnLosuj.Size = new System.Drawing.Size(180, 41);
            this.btnLosuj.TabIndex = 3;
            this.btnLosuj.Text = "Losovanie PC";
            this.btnLosuj.UseVisualStyleBackColor = true;
            this.btnLosuj.Click += new System.EventHandler(this.btnLosuj_Click);
            // 
            // btnVyhodnotenie
            // 
            this.btnVyhodnotenie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVyhodnotenie.Location = new System.Drawing.Point(173, 313);
            this.btnVyhodnotenie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVyhodnotenie.Name = "btnVyhodnotenie";
            this.btnVyhodnotenie.Size = new System.Drawing.Size(204, 48);
            this.btnVyhodnotenie.TabIndex = 4;
            this.btnVyhodnotenie.Text = "Vyhodnotenie";
            this.btnVyhodnotenie.UseVisualStyleBackColor = true;
            this.btnVyhodnotenie.Click += new System.EventHandler(this.btnVyhodnotenie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 407);
            this.Controls.Add(this.btnVyhodnotenie);
            this.Controls.Add(this.btnLosuj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVolbaPC);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Hra kameň, papier, nožnice";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbNoznice;
        private System.Windows.Forms.RadioButton rdbPapier;
        private System.Windows.Forms.RadioButton rdbKamen;
        private System.Windows.Forms.TextBox txtVolbaPC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLosuj;
        private System.Windows.Forms.Button btnVyhodnotenie;
    }
}

