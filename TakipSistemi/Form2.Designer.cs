
namespace TakipSistemi
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.maskedDegisim = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTcNo3 = new System.Windows.Forms.MaskedTextBox();
            this.buttonAzalt = new System.Windows.Forms.Button();
            this.buttonArttır = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Değişim TL :";
            // 
            // maskedDegisim
            // 
            this.maskedDegisim.BeepOnError = true;
            this.maskedDegisim.Location = new System.Drawing.Point(165, 35);
            this.maskedDegisim.Mask = "00000";
            this.maskedDegisim.Name = "maskedDegisim";
            this.maskedDegisim.Size = new System.Drawing.Size(72, 20);
            this.maskedDegisim.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tc No:";
            // 
            // maskedTcNo3
            // 
            this.maskedTcNo3.BeepOnError = true;
            this.maskedTcNo3.Location = new System.Drawing.Point(165, 6);
            this.maskedTcNo3.Mask = "00000000000";
            this.maskedTcNo3.Name = "maskedTcNo3";
            this.maskedTcNo3.Size = new System.Drawing.Size(72, 20);
            this.maskedTcNo3.TabIndex = 4;
            // 
            // buttonAzalt
            // 
            this.buttonAzalt.Location = new System.Drawing.Point(165, 70);
            this.buttonAzalt.Name = "buttonAzalt";
            this.buttonAzalt.Size = new System.Drawing.Size(75, 23);
            this.buttonAzalt.TabIndex = 5;
            this.buttonAzalt.Text = "Azalt";
            this.buttonAzalt.UseVisualStyleBackColor = true;
            this.buttonAzalt.Click += new System.EventHandler(this.buttonAzalt_Click);
            // 
            // buttonArttır
            // 
            this.buttonArttır.Location = new System.Drawing.Point(79, 70);
            this.buttonArttır.Name = "buttonArttır";
            this.buttonArttır.Size = new System.Drawing.Size(75, 23);
            this.buttonArttır.TabIndex = 6;
            this.buttonArttır.Text = "Arttır";
            this.buttonArttır.UseVisualStyleBackColor = true;
            this.buttonArttır.Click += new System.EventHandler(this.buttonArttır_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 123);
            this.Controls.Add(this.buttonArttır);
            this.Controls.Add(this.buttonAzalt);
            this.Controls.Add(this.maskedTcNo3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedDegisim);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Maaş Güncelleme";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedDegisim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTcNo3;
        private System.Windows.Forms.Button buttonAzalt;
        private System.Windows.Forms.Button buttonArttır;
    }
}