
namespace PrepocetKmNaMile
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
            this.txtKM = new System.Windows.Forms.TextBox();
            this.txtMile = new System.Windows.Forms.TextBox();
            this.btnPrepocitaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kilometre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Míle";
            // 
            // txtKM
            // 
            this.txtKM.Location = new System.Drawing.Point(182, 38);
            this.txtKM.Name = "txtKM";
            this.txtKM.Size = new System.Drawing.Size(176, 27);
            this.txtKM.TabIndex = 2;
            // 
            // txtMile
            // 
            this.txtMile.Location = new System.Drawing.Point(182, 118);
            this.txtMile.Name = "txtMile";
            this.txtMile.Size = new System.Drawing.Size(175, 27);
            this.txtMile.TabIndex = 3;
            // 
            // btnPrepocitaj
            // 
            this.btnPrepocitaj.Location = new System.Drawing.Point(400, 33);
            this.btnPrepocitaj.Name = "btnPrepocitaj";
            this.btnPrepocitaj.Size = new System.Drawing.Size(140, 111);
            this.btnPrepocitaj.TabIndex = 4;
            this.btnPrepocitaj.Text = "Prepočítaj";
            this.btnPrepocitaj.UseVisualStyleBackColor = true;
            this.btnPrepocitaj.Click += new System.EventHandler(this.btnPrepocitaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 198);
            this.Controls.Add(this.btnPrepocitaj);
            this.Controls.Add(this.txtMile);
            this.Controls.Add(this.txtKM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Prepočet km na míle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKM;
        private System.Windows.Forms.TextBox txtMile;
        private System.Windows.Forms.Button btnPrepocitaj;
    }
}

