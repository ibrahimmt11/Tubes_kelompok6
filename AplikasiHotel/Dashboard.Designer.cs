namespace AplikasiHotel
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label9 = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabAryaHotel = new System.Windows.Forms.TabControl();
            this.informasiTab = new System.Windows.Forms.TabPage();
            this.comboBoxJenisKamar = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.labelInformasiHarga = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnCek = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pesanKmrTab = new System.Windows.Forms.TabPage();
            this.jenisComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hariNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.namaTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.cekKmrTab = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.statusKmrLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cekKmrTextBox = new System.Windows.Forms.TextBox();
            this.cekKmrButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.statusPemesanan = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnPesan = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.inputmakanan = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.pesanButton = new System.Windows.Forms.Button();
            this.labelTotalHarga = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabAryaHotel.SuspendLayout();
            this.informasiTab.SuspendLayout();
            this.pesanKmrTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hariNumericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.cekKmrTab.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(81, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 23);
            this.label9.TabIndex = 44;
            this.label9.Text = "Welcome, Baim";
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(1186, 48);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(118, 39);
            this.logOutButton.TabIndex = 43;
            this.logOutButton.Text = "LogOut";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(510, 41);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(396, 44);
            this.textBox1.TabIndex = 42;
            this.textBox1.Text = "ARYA HOTEL";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabAryaHotel
            // 
            this.tabAryaHotel.Controls.Add(this.informasiTab);
            this.tabAryaHotel.Controls.Add(this.pesanKmrTab);
            this.tabAryaHotel.Controls.Add(this.cekKmrTab);
            this.tabAryaHotel.Controls.Add(this.tabPage1);
            this.tabAryaHotel.Controls.Add(this.tabPage2);
            this.tabAryaHotel.Controls.Add(this.tabPage3);
            this.tabAryaHotel.Controls.Add(this.tabPage4);
            this.tabAryaHotel.Location = new System.Drawing.Point(192, 138);
            this.tabAryaHotel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAryaHotel.Name = "tabAryaHotel";
            this.tabAryaHotel.SelectedIndex = 0;
            this.tabAryaHotel.Size = new System.Drawing.Size(1026, 548);
            this.tabAryaHotel.TabIndex = 45;
            // 
            // informasiTab
            // 
            this.informasiTab.Controls.Add(this.comboBoxJenisKamar);
            this.informasiTab.Controls.Add(this.label20);
            this.informasiTab.Controls.Add(this.labelInformasiHarga);
            this.informasiTab.Controls.Add(this.label18);
            this.informasiTab.Controls.Add(this.btnCek);
            this.informasiTab.Controls.Add(this.label17);
            this.informasiTab.Controls.Add(this.label16);
            this.informasiTab.Controls.Add(this.label15);
            this.informasiTab.Location = new System.Drawing.Point(4, 29);
            this.informasiTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.informasiTab.Name = "informasiTab";
            this.informasiTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.informasiTab.Size = new System.Drawing.Size(1018, 515);
            this.informasiTab.TabIndex = 1;
            this.informasiTab.Text = "Informasi Hotel";
            this.informasiTab.UseVisualStyleBackColor = true;
            // 
            // comboBoxJenisKamar
            // 
            this.comboBoxJenisKamar.FormattingEnabled = true;
            this.comboBoxJenisKamar.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Suite"});
            this.comboBoxJenisKamar.Location = new System.Drawing.Point(369, 364);
            this.comboBoxJenisKamar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxJenisKamar.Name = "comboBoxJenisKamar";
            this.comboBoxJenisKamar.Size = new System.Drawing.Size(157, 28);
            this.comboBoxJenisKamar.TabIndex = 53;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.DarkGray;
            this.label20.Location = new System.Drawing.Point(600, 331);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 20);
            this.label20.TabIndex = 52;
            this.label20.Text = "Harga:";
            // 
            // labelInformasiHarga
            // 
            this.labelInformasiHarga.BackColor = System.Drawing.Color.White;
            this.labelInformasiHarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelInformasiHarga.Location = new System.Drawing.Point(600, 354);
            this.labelInformasiHarga.Name = "labelInformasiHarga";
            this.labelInformasiHarga.Size = new System.Drawing.Size(120, 41);
            this.labelInformasiHarga.TabIndex = 51;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.DarkGray;
            this.label18.Location = new System.Drawing.Point(364, 331);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(170, 20);
            this.label18.TabIndex = 50;
            this.label18.Text = "Masukkan jenis kamar:";
            // 
            // btnCek
            // 
            this.btnCek.Location = new System.Drawing.Point(368, 412);
            this.btnCek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCek.Name = "btnCek";
            this.btnCek.Size = new System.Drawing.Size(76, 36);
            this.btnCek.TabIndex = 49;
            this.btnCek.Text = "Cek";
            this.btnCek.UseVisualStyleBackColor = true;
            this.btnCek.Click += new System.EventHandler(this.btnCek_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(364, 302);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 20);
            this.label17.TabIndex = 47;
            this.label17.Text = "Cek Harga";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(364, 74);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(628, 228);
            this.label16.TabIndex = 46;
            this.label16.Text = resources.GetString("label16.Text");
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(364, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 23);
            this.label15.TabIndex = 45;
            this.label15.Text = "Arya Hotel";
            // 
            // pesanKmrTab
            // 
            this.pesanKmrTab.Controls.Add(this.label3);
            this.pesanKmrTab.Controls.Add(this.jenisComboBox);
            this.pesanKmrTab.Controls.Add(this.label5);
            this.pesanKmrTab.Controls.Add(this.hariNumericUpDown);
            this.pesanKmrTab.Controls.Add(this.label6);
            this.pesanKmrTab.Controls.Add(this.panel2);
            this.pesanKmrTab.Controls.Add(this.label2);
            this.pesanKmrTab.Controls.Add(this.label1);
            this.pesanKmrTab.Controls.Add(this.namaTextBox);
            this.pesanKmrTab.Controls.Add(this.panel1);
            this.pesanKmrTab.Location = new System.Drawing.Point(4, 29);
            this.pesanKmrTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pesanKmrTab.Name = "pesanKmrTab";
            this.pesanKmrTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pesanKmrTab.Size = new System.Drawing.Size(1018, 515);
            this.pesanKmrTab.TabIndex = 0;
            this.pesanKmrTab.Text = "Pesan Kamar";
            this.pesanKmrTab.UseVisualStyleBackColor = true;
            // 
            // jenisComboBox
            // 
            this.jenisComboBox.FormattingEnabled = true;
            this.jenisComboBox.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Suite"});
            this.jenisComboBox.Location = new System.Drawing.Point(512, 141);
            this.jenisComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.jenisComboBox.Name = "jenisComboBox";
            this.jenisComboBox.Size = new System.Drawing.Size(167, 28);
            this.jenisComboBox.TabIndex = 38;
            this.jenisComboBox.SelectedIndexChanged += new System.EventHandler(this.jenisComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(640, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "/hari";
            // 
            // hariNumericUpDown
            // 
            this.hariNumericUpDown.Location = new System.Drawing.Point(514, 240);
            this.hariNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hariNumericUpDown.Name = "hariNumericUpDown";
            this.hariNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.hariNumericUpDown.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(509, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Jenis Kamar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(510, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Lama menginap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nama";
            // 
            // namaTextBox
            // 
            this.namaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.namaTextBox.Location = new System.Drawing.Point(159, 141);
            this.namaTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.namaTextBox.Multiline = true;
            this.namaTextBox.Name = "namaTextBox";
            this.namaTextBox.Size = new System.Drawing.Size(245, 48);
            this.namaTextBox.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Location = new System.Drawing.Point(112, 52);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 411);
            this.panel1.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 20);
            this.label10.TabIndex = 41;
            this.label10.Text = "Data Diri";
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextBox.Location = new System.Drawing.Point(47, 188);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailTextBox.Multiline = true;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(245, 48);
            this.emailTextBox.TabIndex = 33;
            // 
            // cekKmrTab
            // 
            this.cekKmrTab.Controls.Add(this.panel3);
            this.cekKmrTab.Location = new System.Drawing.Point(4, 29);
            this.cekKmrTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekKmrTab.Name = "cekKmrTab";
            this.cekKmrTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekKmrTab.Size = new System.Drawing.Size(1018, 515);
            this.cekKmrTab.TabIndex = 2;
            this.cekKmrTab.Text = "Cek Kamar";
            this.cekKmrTab.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.statusKmrLabel);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.cekKmrTextBox);
            this.panel3.Controls.Add(this.cekKmrButton);
            this.panel3.Controls.Add(this.listBox1);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(288, 90);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(483, 326);
            this.panel3.TabIndex = 2;
            // 
            // statusKmrLabel
            // 
            this.statusKmrLabel.BackColor = System.Drawing.SystemColors.Window;
            this.statusKmrLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.statusKmrLabel.Location = new System.Drawing.Point(232, 172);
            this.statusKmrLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statusKmrLabel.Name = "statusKmrLabel";
            this.statusKmrLabel.Size = new System.Drawing.Size(158, 39);
            this.statusKmrLabel.TabIndex = 6;
            this.statusKmrLabel.Text = "Status";
            this.statusKmrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.statusKmrLabel.Click += new System.EventHandler(this.statusKmrLabel_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(209, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 20);
            this.label13.TabIndex = 5;
            this.label13.Text = "Cek kamar ";
            // 
            // cekKmrTextBox
            // 
            this.cekKmrTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cekKmrTextBox.Location = new System.Drawing.Point(232, 128);
            this.cekKmrTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekKmrTextBox.Multiline = true;
            this.cekKmrTextBox.Name = "cekKmrTextBox";
            this.cekKmrTextBox.Size = new System.Drawing.Size(158, 39);
            this.cekKmrTextBox.TabIndex = 4;
            this.cekKmrTextBox.TextChanged += new System.EventHandler(this.cekKmrTextBox_TextChanged);
            // 
            // cekKmrButton
            // 
            this.cekKmrButton.Location = new System.Drawing.Point(263, 218);
            this.cekKmrButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekKmrButton.Name = "cekKmrButton";
            this.cekKmrButton.Size = new System.Drawing.Size(102, 31);
            this.cekKmrButton.TabIndex = 3;
            this.cekKmrButton.Text = "Cek";
            this.cekKmrButton.UseVisualStyleBackColor = true;
            this.cekKmrButton.Click += new System.EventHandler(this.cekKmrButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Kamar 101",
            "Kamar 102",
            "Kamar 103",
            "Kamar 104",
            "Kamar 105",
            "Kamar 106",
            "Kamar 107",
            "Kamar 108",
            "Kamar 109",
            "Kamar 201",
            "Kamar 202",
            "Kamar 203",
            "Kamar 204",
            "Kamar 205",
            "Kamar 206",
            "Kamar 207",
            "Kamar 208",
            "Kamar 209",
            "Kamar 301",
            "Kamar 302",
            "Kamar 303",
            "Kamar 304",
            "Kamar 305",
            "Kamar 306",
            "Kamar 307",
            "Kamar 308",
            "Kamar 309",
            "",
            ""});
            this.listBox1.Location = new System.Drawing.Point(65, 74);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(92, 224);
            this.listBox1.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Kamar yang tersedia";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.statusPemesanan);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.btnPesan);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.inputmakanan);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1018, 515);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Pesan Makan";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // statusPemesanan
            // 
            this.statusPemesanan.AutoSize = true;
            this.statusPemesanan.Location = new System.Drawing.Point(551, 419);
            this.statusPemesanan.Name = "statusPemesanan";
            this.statusPemesanan.Size = new System.Drawing.Size(0, 20);
            this.statusPemesanan.TabIndex = 8;
            this.statusPemesanan.Click += new System.EventHandler(this.Pemesanan_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(274, 192);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(146, 120);
            this.label21.TabIndex = 7;
            this.label21.Text = "MENU TERSEDIA:\r\n\r\n1.Nasi Goreng\r\n2.Mie Goreng\r\n3.Ayam Bakar\r\n4.Sate Ayam";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // btnPesan
            // 
            this.btnPesan.Location = new System.Drawing.Point(579, 290);
            this.btnPesan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPesan.Name = "btnPesan";
            this.btnPesan.Size = new System.Drawing.Size(169, 61);
            this.btnPesan.TabIndex = 6;
            this.btnPesan.Text = "Pesan";
            this.btnPesan.UseVisualStyleBackColor = true;
            this.btnPesan.Click += new System.EventHandler(this.btnPesan_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(411, 419);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 20);
            this.label22.TabIndex = 5;
            // 
            // inputmakanan
            // 
            this.inputmakanan.Location = new System.Drawing.Point(579, 169);
            this.inputmakanan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputmakanan.Name = "inputmakanan";
            this.inputmakanan.Size = new System.Drawing.Size(168, 26);
            this.inputmakanan.TabIndex = 4;
            this.inputmakanan.TextChanged += new System.EventHandler(this.inputmakanan_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1018, 515);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Pelayanan";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(1018, 515);
            this.tabPage3.TabIndex = 5;
            this.tabPage3.Text = "Riwayat Reservasi";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Size = new System.Drawing.Size(1018, 515);
            this.tabPage4.TabIndex = 6;
            this.tabPage4.Text = "CheckOut";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(214, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Total";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(295, 328);
            this.nextButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(86, 34);
            this.nextButton.TabIndex = 37;
            this.nextButton.Text = "Check";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 20);
            this.label11.TabIndex = 42;
            this.label11.Text = "Reservasi";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(219, 272);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(30, 20);
            this.label23.TabIndex = 43;
            this.label23.Text = "Rp";
            // 
            // pesanButton
            // 
            this.pesanButton.Location = new System.Drawing.Point(296, 365);
            this.pesanButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pesanButton.Name = "pesanButton";
            this.pesanButton.Size = new System.Drawing.Size(86, 34);
            this.pesanButton.TabIndex = 44;
            this.pesanButton.Text = "Pesan";
            this.pesanButton.UseVisualStyleBackColor = true;
            this.pesanButton.Click += new System.EventHandler(this.pesanButton_Click);
            // 
            // labelTotalHarga
            // 
            this.labelTotalHarga.AutoSize = true;
            this.labelTotalHarga.Location = new System.Drawing.Point(254, 272);
            this.labelTotalHarga.Name = "labelTotalHarga";
            this.labelTotalHarga.Size = new System.Drawing.Size(0, 20);
            this.labelTotalHarga.TabIndex = 45;
            // 
            // totalLabel
            // 
            this.totalLabel.BackColor = System.Drawing.Color.White;
            this.totalLabel.Location = new System.Drawing.Point(246, 272);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(135, 39);
            this.totalLabel.TabIndex = 46;
            this.totalLabel.Click += new System.EventHandler(this.totalLabel_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.totalLabel);
            this.panel2.Controls.Add(this.labelTotalHarga);
            this.panel2.Controls.Add(this.pesanButton);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.nextButton);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(461, 52);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(446, 411);
            this.panel2.TabIndex = 26;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1416, 708);
            this.Controls.Add(this.tabAryaHotel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.tabAryaHotel.ResumeLayout(false);
            this.informasiTab.ResumeLayout(false);
            this.informasiTab.PerformLayout();
            this.pesanKmrTab.ResumeLayout(false);
            this.pesanKmrTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hariNumericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cekKmrTab.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabAryaHotel;
        private System.Windows.Forms.TabPage informasiTab;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label labelInformasiHarga;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnCek;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage pesanKmrTab;
        private System.Windows.Forms.ComboBox jenisComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown hariNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox namaTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TabPage cekKmrTab;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label statusKmrLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox cekKmrTextBox;
        private System.Windows.Forms.Button cekKmrButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label statusPemesanan;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnPesan;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox inputmakanan;
        private System.Windows.Forms.ComboBox comboBoxJenisKamar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label labelTotalHarga;
        private System.Windows.Forms.Button pesanButton;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label label7;
    }
}