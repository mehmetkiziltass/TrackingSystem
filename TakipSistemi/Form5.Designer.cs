
namespace TakipSistemi
{
    partial class Form5
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridEnYuksekMaas = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEnYuksekMaas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridEnYuksekMaas);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 155);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personeller";
            // 
            // dataGridEnYuksekMaas
            // 
            this.dataGridEnYuksekMaas.AllowUserToAddRows = false;
            this.dataGridEnYuksekMaas.AllowUserToDeleteRows = false;
            this.dataGridEnYuksekMaas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEnYuksekMaas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridEnYuksekMaas.Location = new System.Drawing.Point(3, 16);
            this.dataGridEnYuksekMaas.Name = "dataGridEnYuksekMaas";
            this.dataGridEnYuksekMaas.ReadOnly = true;
            this.dataGridEnYuksekMaas.Size = new System.Drawing.Size(343, 136);
            this.dataGridEnYuksekMaas.TabIndex = 0;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 158);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form5";
            this.Text = "En Yüksek Maaş Alanlar";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEnYuksekMaas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridEnYuksekMaas;
    }
}