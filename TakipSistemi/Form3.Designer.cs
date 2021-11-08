
namespace TakipSistemi
{
    partial class Form3
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
            this.employeeDataSet1 = new TakipSistemi.EmployeeDataSet();
            this.maskedTcNo3 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonIstenCikar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeDataSet1
            // 
            this.employeeDataSet1.DataSetName = "EmployeeDataSet";
            this.employeeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maskedTcNo3
            // 
            this.maskedTcNo3.BeepOnError = true;
            this.maskedTcNo3.Location = new System.Drawing.Point(112, 12);
            this.maskedTcNo3.Mask = "00000000000";
            this.maskedTcNo3.Name = "maskedTcNo3";
            this.maskedTcNo3.Size = new System.Drawing.Size(87, 20);
            this.maskedTcNo3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tc No:";
            // 
            // buttonIstenCikar
            // 
            this.buttonIstenCikar.Location = new System.Drawing.Point(112, 50);
            this.buttonIstenCikar.Name = "buttonIstenCikar";
            this.buttonIstenCikar.Size = new System.Drawing.Size(75, 23);
            this.buttonIstenCikar.TabIndex = 3;
            this.buttonIstenCikar.Text = "İşten Çıkar ";
            this.buttonIstenCikar.UseVisualStyleBackColor = true;
            this.buttonIstenCikar.Click += new System.EventHandler(this.buttonIstenCikar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 94);
            this.Controls.Add(this.buttonIstenCikar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTcNo3);
            this.Name = "Form3";
            this.Text = "İşten Çıkarma";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private EmployeeDataSet employeeDataSet1;
        private System.Windows.Forms.MaskedTextBox maskedTcNo3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonIstenCikar;
    }
}