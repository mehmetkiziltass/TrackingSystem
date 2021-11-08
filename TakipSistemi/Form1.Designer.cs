
namespace TakipSistemi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateBaslamaTarihi = new System.Windows.Forms.DateTimePicker();
            this.maskedMaas = new System.Windows.Forms.MaskedTextBox();
            this.comboSehir = new System.Windows.Forms.ComboBox();
            this.textMeslek = new System.Windows.Forms.TextBox();
            this.maskedTelefon = new System.Windows.Forms.MaskedTextBox();
            this.textSoyad = new System.Windows.Forms.TextBox();
            this.textAd = new System.Windows.Forms.TextBox();
            this.maskedTcNo = new System.Windows.Forms.MaskedTextBox();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tcNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baslamaTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDataSet = new TakipSistemi.EmployeeDataSet();
            this.table_EmployeeTableAdapter = new TakipSistemi.EmployeeDataSetTableAdapters.Table_EmployeeTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonEnAzMaas = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonEnYuksekMaas = new System.Windows.Forms.Button();
            this.buttonMaasGuncelle = new System.Windows.Forms.Button();
            this.buttonIstenCikar = new System.Windows.Forms.Button();
            this.buttonYenile = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonAra = new System.Windows.Forms.Button();
            this.maskedPersonelAra = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableEmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateBaslamaTarihi);
            this.groupBox1.Controls.Add(this.maskedMaas);
            this.groupBox1.Controls.Add(this.comboSehir);
            this.groupBox1.Controls.Add(this.textMeslek);
            this.groupBox1.Controls.Add(this.maskedTelefon);
            this.groupBox1.Controls.Add(this.textSoyad);
            this.groupBox1.Controls.Add(this.textAd);
            this.groupBox1.Controls.Add(this.maskedTcNo);
            this.groupBox1.Controls.Add(this.buttonKaydet);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel";
            // 
            // dateBaslamaTarihi
            // 
            this.dateBaslamaTarihi.Location = new System.Drawing.Point(282, 141);
            this.dateBaslamaTarihi.Name = "dateBaslamaTarihi";
            this.dateBaslamaTarihi.Size = new System.Drawing.Size(164, 20);
            this.dateBaslamaTarihi.TabIndex = 16;
            // 
            // maskedMaas
            // 
            this.maskedMaas.BeepOnError = true;
            this.maskedMaas.Location = new System.Drawing.Point(282, 102);
            this.maskedMaas.Mask = "00000";
            this.maskedMaas.Name = "maskedMaas";
            this.maskedMaas.Size = new System.Drawing.Size(164, 20);
            this.maskedMaas.TabIndex = 15;
            // 
            // comboSehir
            // 
            this.comboSehir.FormattingEnabled = true;
            this.comboSehir.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı ",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin ",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl ",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum ",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum ",
            "Eskişehir",
            "Gaziantep",
            "Giresun ",
            "Gümüşhane ",
            "Hakkari",
            "Hatay",
            "Isparta",
            "Mersin",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Kahramanmaraş",
            "Mardin ",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat ",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis ",
            "Osmaniye",
            "Düzce"});
            this.comboSehir.Location = new System.Drawing.Point(282, 67);
            this.comboSehir.Name = "comboSehir";
            this.comboSehir.Size = new System.Drawing.Size(164, 21);
            this.comboSehir.TabIndex = 14;
            // 
            // textMeslek
            // 
            this.textMeslek.Location = new System.Drawing.Point(282, 29);
            this.textMeslek.Name = "textMeslek";
            this.textMeslek.Size = new System.Drawing.Size(164, 20);
            this.textMeslek.TabIndex = 13;
            // 
            // maskedTelefon
            // 
            this.maskedTelefon.BeepOnError = true;
            this.maskedTelefon.Location = new System.Drawing.Point(62, 141);
            this.maskedTelefon.Mask = "0000000000";
            this.maskedTelefon.Name = "maskedTelefon";
            this.maskedTelefon.Size = new System.Drawing.Size(124, 20);
            this.maskedTelefon.TabIndex = 12;
            // 
            // textSoyad
            // 
            this.textSoyad.Location = new System.Drawing.Point(62, 102);
            this.textSoyad.Name = "textSoyad";
            this.textSoyad.Size = new System.Drawing.Size(124, 20);
            this.textSoyad.TabIndex = 11;
            // 
            // textAd
            // 
            this.textAd.Location = new System.Drawing.Point(62, 64);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(124, 20);
            this.textAd.TabIndex = 10;
            // 
            // maskedTcNo
            // 
            this.maskedTcNo.BeepOnError = true;
            this.maskedTcNo.Location = new System.Drawing.Point(62, 29);
            this.maskedTcNo.Mask = "00000000000";
            this.maskedTcNo.Name = "maskedTcNo";
            this.maskedTcNo.Size = new System.Drawing.Size(124, 20);
            this.maskedTcNo.TabIndex = 9;
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(133, 183);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(198, 23);
            this.buttonKaydet.TabIndex = 8;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(192, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Başlama Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Maaş:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Şehir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Meslek:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tc No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(1, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(851, 239);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personeller";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tcNoDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.meslekDataGridViewTextBoxColumn,
            this.sehirDataGridViewTextBoxColumn,
            this.maasDataGridViewTextBoxColumn,
            this.baslamaTarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableEmployeeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(845, 220);
            this.dataGridView1.TabIndex = 0;
            // 
            // tcNoDataGridViewTextBoxColumn
            // 
            this.tcNoDataGridViewTextBoxColumn.DataPropertyName = "TcNo";
            this.tcNoDataGridViewTextBoxColumn.HeaderText = "TcNo";
            this.tcNoDataGridViewTextBoxColumn.Name = "tcNoDataGridViewTextBoxColumn";
            this.tcNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // meslekDataGridViewTextBoxColumn
            // 
            this.meslekDataGridViewTextBoxColumn.DataPropertyName = "Meslek";
            this.meslekDataGridViewTextBoxColumn.HeaderText = "Meslek";
            this.meslekDataGridViewTextBoxColumn.Name = "meslekDataGridViewTextBoxColumn";
            this.meslekDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sehirDataGridViewTextBoxColumn
            // 
            this.sehirDataGridViewTextBoxColumn.DataPropertyName = "Sehir";
            this.sehirDataGridViewTextBoxColumn.HeaderText = "Sehir";
            this.sehirDataGridViewTextBoxColumn.Name = "sehirDataGridViewTextBoxColumn";
            this.sehirDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maasDataGridViewTextBoxColumn
            // 
            this.maasDataGridViewTextBoxColumn.DataPropertyName = "Maas";
            this.maasDataGridViewTextBoxColumn.HeaderText = "Maas";
            this.maasDataGridViewTextBoxColumn.Name = "maasDataGridViewTextBoxColumn";
            this.maasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // baslamaTarihiDataGridViewTextBoxColumn
            // 
            this.baslamaTarihiDataGridViewTextBoxColumn.DataPropertyName = "BaslamaTarihi";
            this.baslamaTarihiDataGridViewTextBoxColumn.HeaderText = "BaslamaTarihi";
            this.baslamaTarihiDataGridViewTextBoxColumn.Name = "baslamaTarihiDataGridViewTextBoxColumn";
            this.baslamaTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableEmployeeBindingSource
            // 
            this.tableEmployeeBindingSource.DataMember = "Table_Employee";
            this.tableEmployeeBindingSource.DataSource = this.employeeDataSet;
            // 
            // employeeDataSet
            // 
            this.employeeDataSet.DataSetName = "EmployeeDataSet";
            this.employeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_EmployeeTableAdapter
            // 
            this.table_EmployeeTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonEnAzMaas);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.buttonEnYuksekMaas);
            this.groupBox3.Controls.Add(this.buttonMaasGuncelle);
            this.groupBox3.Controls.Add(this.buttonIstenCikar);
            this.groupBox3.Location = new System.Drawing.Point(476, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(373, 212);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İşlemler";
            // 
            // buttonEnAzMaas
            // 
            this.buttonEnAzMaas.Location = new System.Drawing.Point(204, 134);
            this.buttonEnAzMaas.Name = "buttonEnAzMaas";
            this.buttonEnAzMaas.Size = new System.Drawing.Size(161, 23);
            this.buttonEnAzMaas.TabIndex = 8;
            this.buttonEnAzMaas.Text = "En Az Maaş Alanlar";
            this.buttonEnAzMaas.UseVisualStyleBackColor = true;
            this.buttonEnAzMaas.Click += new System.EventHandler(this.buttonEnAzMaas_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(261, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonEnYuksekMaas
            // 
            this.buttonEnYuksekMaas.Location = new System.Drawing.Point(22, 134);
            this.buttonEnYuksekMaas.Name = "buttonEnYuksekMaas";
            this.buttonEnYuksekMaas.Size = new System.Drawing.Size(152, 23);
            this.buttonEnYuksekMaas.TabIndex = 6;
            this.buttonEnYuksekMaas.Text = "En Yüksek Maaş Alanlar";
            this.buttonEnYuksekMaas.UseVisualStyleBackColor = true;
            this.buttonEnYuksekMaas.Click += new System.EventHandler(this.buttonEnYuksekMaas_Click);
            // 
            // buttonMaasGuncelle
            // 
            this.buttonMaasGuncelle.Location = new System.Drawing.Point(225, 32);
            this.buttonMaasGuncelle.Name = "buttonMaasGuncelle";
            this.buttonMaasGuncelle.Size = new System.Drawing.Size(117, 23);
            this.buttonMaasGuncelle.TabIndex = 4;
            this.buttonMaasGuncelle.Text = "Maaş Güncelle";
            this.buttonMaasGuncelle.UseVisualStyleBackColor = true;
            this.buttonMaasGuncelle.Click += new System.EventHandler(this.buttonMaasGuncelle_Click);
            // 
            // buttonIstenCikar
            // 
            this.buttonIstenCikar.Location = new System.Drawing.Point(22, 32);
            this.buttonIstenCikar.Name = "buttonIstenCikar";
            this.buttonIstenCikar.Size = new System.Drawing.Size(122, 23);
            this.buttonIstenCikar.TabIndex = 0;
            this.buttonIstenCikar.Text = "İşten Çıkar";
            this.buttonIstenCikar.UseVisualStyleBackColor = true;
            this.buttonIstenCikar.Click += new System.EventHandler(this.buttonIstenCikar_Click);
            // 
            // buttonYenile
            // 
            this.buttonYenile.Location = new System.Drawing.Point(60, 19);
            this.buttonYenile.Name = "buttonYenile";
            this.buttonYenile.Size = new System.Drawing.Size(75, 24);
            this.buttonYenile.TabIndex = 3;
            this.buttonYenile.Text = "Yenile";
            this.buttonYenile.UseVisualStyleBackColor = true;
            this.buttonYenile.Click += new System.EventHandler(this.buttonYenile_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonYenile);
            this.groupBox4.Location = new System.Drawing.Point(540, 230);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(202, 49);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Güncel Verileri Görmek İçin Yenileyin.";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonAra);
            this.groupBox5.Controls.Add(this.maskedPersonelAra);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(145, 231);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(274, 42);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tc Kimlik Numarası ile Arama";
            // 
            // buttonAra
            // 
            this.buttonAra.Location = new System.Drawing.Point(179, 13);
            this.buttonAra.Name = "buttonAra";
            this.buttonAra.Size = new System.Drawing.Size(75, 23);
            this.buttonAra.TabIndex = 2;
            this.buttonAra.Text = "Ara";
            this.buttonAra.UseVisualStyleBackColor = true;
            this.buttonAra.Click += new System.EventHandler(this.buttonAra_Click);
            // 
            // maskedPersonelAra
            // 
            this.maskedPersonelAra.BeepOnError = true;
            this.maskedPersonelAra.Location = new System.Drawing.Point(62, 16);
            this.maskedPersonelAra.Mask = "00000000000";
            this.maskedPersonelAra.Name = "maskedPersonelAra";
            this.maskedPersonelAra.Size = new System.Drawing.Size(100, 20);
            this.maskedPersonelAra.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tc No:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 488);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Takip Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableEmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateBaslamaTarihi;
        private System.Windows.Forms.MaskedTextBox maskedMaas;
        private System.Windows.Forms.ComboBox comboSehir;
        private System.Windows.Forms.TextBox textMeslek;
        private System.Windows.Forms.MaskedTextBox maskedTelefon;
        private System.Windows.Forms.TextBox textSoyad;
        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.MaskedTextBox maskedTcNo;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EmployeeDataSet employeeDataSet;
        private System.Windows.Forms.BindingSource tableEmployeeBindingSource;
        private EmployeeDataSetTableAdapters.Table_EmployeeTableAdapter table_EmployeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baslamaTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonIstenCikar;
        private System.Windows.Forms.Button buttonYenile;
        private System.Windows.Forms.Button buttonMaasGuncelle;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonEnYuksekMaas;
        private System.Windows.Forms.Button buttonEnAzMaas;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonAra;
        private System.Windows.Forms.MaskedTextBox maskedPersonelAra;
        private System.Windows.Forms.Label label9;
    }
}

