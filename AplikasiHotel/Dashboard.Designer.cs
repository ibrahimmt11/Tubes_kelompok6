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
            this.label20 = new System.Windows.Forms.Label();
            this.labelInformasiHarga = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnCek = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pesanKmrTab = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.floorComboBox = new System.Windows.Forms.ComboBox();
            this.jenisComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hariNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.noKmrTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.namaTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.hargaButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cekKmrTab = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.labelTotalHarga = new System.Windows.Forms.Label();
            this.comboBoxJenisKamar = new System.Windows.Forms.ComboBox();
            this.tabAryaHotel.SuspendLayout();
            this.informasiTab.SuspendLayout();
            this.pesanKmrTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hariNumericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.cekKmrTab.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(72, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 21);
            this.label9.TabIndex = 44;
            this.label9.Text = "Welcome, Baim";
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(1054, 38);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(105, 31);
            this.logOutButton.TabIndex = 43;
            this.logOutButton.Text = "LogOut";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(453, 33);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 36);
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
            this.tabAryaHotel.Location = new System.Drawing.Point(171, 110);
            this.tabAryaHotel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAryaHotel.Name = "tabAryaHotel";
            this.tabAryaHotel.SelectedIndex = 0;
            this.tabAryaHotel.Size = new System.Drawing.Size(912, 438);
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
            this.informasiTab.Location = new System.Drawing.Point(4, 25);
            this.informasiTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.informasiTab.Name = "informasiTab";
            this.informasiTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.informasiTab.Size = new System.Drawing.Size(904, 409);
            this.informasiTab.TabIndex = 1;
            this.informasiTab.Text = "Informasi Hotel";
            this.informasiTab.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.DarkGray;
            this.label20.Location = new System.Drawing.Point(533, 265);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 16);
            this.label20.TabIndex = 52;
            this.label20.Text = "Harga:";
            // 
            // labelInformasiHarga
            // 
            this.labelInformasiHarga.BackColor = System.Drawing.Color.White;
            this.labelInformasiHarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelInformasiHarga.Location = new System.Drawing.Point(533, 283);
            this.labelInformasiHarga.Name = "labelInformasiHarga";
            this.labelInformasiHarga.Size = new System.Drawing.Size(107, 33);
            this.labelInformasiHarga.TabIndex = 51;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.DarkGray;
            this.label18.Location = new System.Drawing.Point(324, 265);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(144, 16);
            this.label18.TabIndex = 50;
            this.label18.Text = "Masukkan jenis kamar:";
            // 
            // btnCek
            // 
            this.btnCek.Location = new System.Drawing.Point(327, 330);
            this.btnCek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCek.Name = "btnCek";
            this.btnCek.Size = new System.Drawing.Size(68, 29);
            this.btnCek.TabIndex = 49;
            this.btnCek.Text = "Cek";
            this.btnCek.UseVisualStyleBackColor = true;
            this.btnCek.Click += new System.EventHandler(this.btnCek_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(324, 242);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 16);
            this.label17.TabIndex = 47;
            this.label17.Text = "Cek Harga";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(324, 59);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(558, 182);
            this.label16.TabIndex = 46;
            this.label16.Text = resources.GetString("label16.Text");
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(324, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 21);
            this.label15.TabIndex = 45;
            this.label15.Text = "Arya Hotel";
            // 
            // pesanKmrTab
            // 
            this.pesanKmrTab.Controls.Add(this.label8);
            this.pesanKmrTab.Controls.Add(this.floorComboBox);
            this.pesanKmrTab.Controls.Add(this.jenisComboBox);
            this.pesanKmrTab.Controls.Add(this.label5);
            this.pesanKmrTab.Controls.Add(this.hariNumericUpDown);
            this.pesanKmrTab.Controls.Add(this.noKmrTextBox);
            this.pesanKmrTab.Controls.Add(this.label6);
            this.pesanKmrTab.Controls.Add(this.label4);
            this.pesanKmrTab.Controls.Add(this.label3);
            this.pesanKmrTab.Controls.Add(this.label2);
            this.pesanKmrTab.Controls.Add(this.label1);
            this.pesanKmrTab.Controls.Add(this.namaTextBox);
            this.pesanKmrTab.Controls.Add(this.panel1);
            this.pesanKmrTab.Controls.Add(this.panel2);
            this.pesanKmrTab.Location = new System.Drawing.Point(4, 25);
            this.pesanKmrTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pesanKmrTab.Name = "pesanKmrTab";
            this.pesanKmrTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pesanKmrTab.Size = new System.Drawing.Size(904, 409);
            this.pesanKmrTab.TabIndex = 0;
            this.pesanKmrTab.Text = "Pesan Kamar";
            this.pesanKmrTab.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(454, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 40;
            this.label8.Text = "Lantai";
            // 
            // floorComboBox
            // 
            this.floorComboBox.FormattingEnabled = true;
            this.floorComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.floorComboBox.Location = new System.Drawing.Point(458, 110);
            this.floorComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.floorComboBox.Name = "floorComboBox";
            this.floorComboBox.Size = new System.Drawing.Size(56, 24);
            this.floorComboBox.TabIndex = 39;
            // 
            // jenisComboBox
            // 
            this.jenisComboBox.FormattingEnabled = true;
            this.jenisComboBox.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Suite"});
            this.jenisComboBox.Location = new System.Drawing.Point(572, 110);
            this.jenisComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.jenisComboBox.Name = "jenisComboBox";
            this.jenisComboBox.Size = new System.Drawing.Size(176, 24);
            this.jenisComboBox.TabIndex = 38;
            this.jenisComboBox.SelectedIndexChanged += new System.EventHandler(this.jenisComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(716, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "/hari";
            // 
            // hariNumericUpDown
            // 
            this.hariNumericUpDown.Location = new System.Drawing.Point(604, 199);
            this.hariNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hariNumericUpDown.Name = "hariNumericUpDown";
            this.hariNumericUpDown.Size = new System.Drawing.Size(107, 22);
            this.hariNumericUpDown.TabIndex = 34;
            // 
            // noKmrTextBox
            // 
            this.noKmrTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noKmrTextBox.Location = new System.Drawing.Point(458, 195);
            this.noKmrTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.noKmrTextBox.Multiline = true;
            this.noKmrTextBox.Name = "noKmrTextBox";
            this.noKmrTextBox.Size = new System.Drawing.Size(53, 25);
            this.noKmrTextBox.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(569, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Jenis Kamar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "No kamar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(600, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Lama menginap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nama";
            // 
            // namaTextBox
            // 
            this.namaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.namaTextBox.Location = new System.Drawing.Point(141, 113);
            this.namaTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.namaTextBox.Multiline = true;
            this.namaTextBox.Name = "namaTextBox";
            this.namaTextBox.Size = new System.Drawing.Size(218, 38);
            this.namaTextBox.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Location = new System.Drawing.Point(100, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 329);
            this.panel1.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 16);
            this.label10.TabIndex = 41;
            this.label10.Text = "Data Diri";
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextBox.Location = new System.Drawing.Point(42, 150);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailTextBox.Multiline = true;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(218, 38);
            this.emailTextBox.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelTotalHarga);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.hargaButton);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(410, 42);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 329);
            this.panel2.TabIndex = 26;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(263, 292);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 27);
            this.button3.TabIndex = 44;
            this.button3.Text = "Pesan";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(195, 218);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(25, 16);
            this.label23.TabIndex = 43;
            this.label23.Text = "Rp";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 16);
            this.label11.TabIndex = 42;
            this.label11.Text = "Reservasi";
            // 
            // hargaButton
            // 
            this.hargaButton.Location = new System.Drawing.Point(262, 262);
            this.hargaButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hargaButton.Name = "hargaButton";
            this.hargaButton.Size = new System.Drawing.Size(76, 27);
            this.hargaButton.TabIndex = 37;
            this.hargaButton.Text = "Harga";
            this.hargaButton.UseVisualStyleBackColor = true;
            this.hargaButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "Total";
            // 
            // cekKmrTab
            // 
            this.cekKmrTab.Controls.Add(this.panel3);
            this.cekKmrTab.Location = new System.Drawing.Point(4, 25);
            this.cekKmrTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekKmrTab.Name = "cekKmrTab";
            this.cekKmrTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekKmrTab.Size = new System.Drawing.Size(904, 409);
            this.cekKmrTab.TabIndex = 2;
            this.cekKmrTab.Text = "Cek Kamar";
            this.cekKmrTab.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.listBox1);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(256, 72);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(429, 261);
            this.panel3.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.Window;
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label14.Location = new System.Drawing.Point(206, 138);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 31);
            this.label14.TabIndex = 6;
            this.label14.Text = "Status";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(186, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 16);
            this.label13.TabIndex = 5;
            this.label13.Text = "Cek kamar ";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(206, 102);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 31);
            this.textBox2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 174);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cek";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
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
            "Kamar 110",
            ""});
            this.listBox1.Location = new System.Drawing.Point(58, 59);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(82, 180);
            this.listBox1.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 16);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(904, 409);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Pesan Makan";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // statusPemesanan
            // 
            this.statusPemesanan.AutoSize = true;
            this.statusPemesanan.Location = new System.Drawing.Point(490, 335);
            this.statusPemesanan.Name = "statusPemesanan";
            this.statusPemesanan.Size = new System.Drawing.Size(0, 16);
            this.statusPemesanan.TabIndex = 8;
            this.statusPemesanan.Click += new System.EventHandler(this.Pemesanan_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(244, 154);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(121, 96);
            this.label21.TabIndex = 7;
            this.label21.Text = "MENU TERSEDIA:\r\n\r\n1.Nasi Goreng\r\n2.Mie Goreng\r\n3.Ayam Bakar\r\n4.Sate Ayam";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // btnPesan
            // 
            this.btnPesan.Location = new System.Drawing.Point(515, 232);
            this.btnPesan.Name = "btnPesan";
            this.btnPesan.Size = new System.Drawing.Size(150, 49);
            this.btnPesan.TabIndex = 6;
            this.btnPesan.Text = "Pesan";
            this.btnPesan.UseVisualStyleBackColor = true;
            this.btnPesan.Click += new System.EventHandler(this.btnPesan_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(365, 335);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 16);
            this.label22.TabIndex = 5;
            // 
            // inputmakanan
            // 
            this.inputmakanan.Location = new System.Drawing.Point(515, 135);
            this.inputmakanan.Name = "inputmakanan";
            this.inputmakanan.Size = new System.Drawing.Size(150, 22);
            this.inputmakanan.TabIndex = 4;
            this.inputmakanan.TextChanged += new System.EventHandler(this.inputmakanan_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(904, 409);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Pelayanan";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(904, 409);
            this.tabPage3.TabIndex = 5;
            this.tabPage3.Text = "Riwayat Reservasi";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Size = new System.Drawing.Size(904, 409);
            this.tabPage4.TabIndex = 6;
            this.tabPage4.Text = "CheckOut";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // labelTotalHarga
            // 
            this.labelTotalHarga.AutoSize = true;
            this.labelTotalHarga.Location = new System.Drawing.Point(226, 218);
            this.labelTotalHarga.Name = "labelTotalHarga";
            this.labelTotalHarga.Size = new System.Drawing.Size(0, 16);
            this.labelTotalHarga.TabIndex = 45;
            // 
            // comboBoxJenisKamar
            // 
            this.comboBoxJenisKamar.FormattingEnabled = true;
            this.comboBoxJenisKamar.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Suite"});
            this.comboBoxJenisKamar.Location = new System.Drawing.Point(328, 291);
            this.comboBoxJenisKamar.Name = "comboBoxJenisKamar";
            this.comboBoxJenisKamar.Size = new System.Drawing.Size(140, 24);
            this.comboBoxJenisKamar.TabIndex = 53;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1259, 566);
            this.Controls.Add(this.tabAryaHotel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.cekKmrTab.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox floorComboBox;
        private System.Windows.Forms.ComboBox jenisComboBox;
        private System.Windows.Forms.Button hargaButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown hariNumericUpDown;
        private System.Windows.Forms.TextBox noKmrTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox namaTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage cekKmrTab;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label labelTotalHarga;
        private System.Windows.Forms.ComboBox comboBoxJenisKamar;
    }
}