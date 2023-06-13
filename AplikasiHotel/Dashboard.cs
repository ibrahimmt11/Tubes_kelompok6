using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace AplikasiHotel
{
    public partial class Dashboard : Form
    {
        public int totalAmount = 0;
        int jmlKmr1 = 9;
        int jmlKmr2 = 9;
        int jmlKmr3 = 9;
        int[] noKmr1 = new int[9] { 101, 102, 103, 104, 105, 106, 107, 108, 109 };
        int[] noKmr2 = new int[9] { 201, 202, 203, 204, 205, 206, 207, 208, 209 };
        int[] noKmr3 = new int[9] { 301, 302, 303, 304, 305, 306, 307, 308, 309 };
        string[] status1 = new string[9] { "tersedia", "tersedia", "tersedia", "tersedia", "tersedia", "tersedia", "tersedia", "tersedia", "tersedia" };
        string[] status2 = new string[9] { "tersedia", "tersedia", "tersedia", "tersedia", "tersedia", "tersedia", "tersedia", "tersedia", "tersedia" };
        string[] status3 = new string[9] { "tersedia", "tersedia", "tersedia", "tersedia", "tersedia", "tersedia", "tersedia", "tersedia", "tersedia" };
        Dictionary<int, string> menuMakanan = new Dictionary<int, string>()
        {
            { 1, "Nasi Goreng" },
            { 2, "Mie Goreng" },
            { 3, "Ayam Bakar" },
            { 4, "Sate Ayam" }
        };
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //FITUR PESAN MAKAN

        //Menampilkan Menu Yang Tersedia 
        private void label21_Click(object sender, EventArgs e)
        {
            string menuText = "Menu Makanan Tersedia:\n";

            foreach (var menuItem in menuMakanan)
            {
                menuText += $"{menuItem.Key}. {menuItem.Value}\n";
            }

            label2.Text = menuText;
        }

        //button untuk melakukan pemesanan 
        private void btnPesan_Click(object sender, EventArgs e)
        {
            int nomorMakanan;
            if (int.TryParse(inputmakanan.Text, out nomorMakanan))
            {
                if (menuMakanan.ContainsKey(nomorMakanan))
                {
                    string makanan = menuMakanan[nomorMakanan];
                    statusPemesanan.Text = "Pemesanan berhasil: " + makanan;
                }
                else
                {
                    statusPemesanan.Text = "Nomor makanan tidak valid";
                }
            }
            else
            {
                statusPemesanan.Text = "Nomor makanan harus berupa angka";
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void status_Click(object sender, EventArgs e)
        {

        }

        private void Pemesanan_Click(object sender, EventArgs e)
        {

        }

        private void inputmakanan_TextChanged(object sender, EventArgs e)
        {

        }

        //FITUR PESAN KAMAR
        private void jenisComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        private bool isDataValid = false; // Flag untuk menandakan validitas data
        private void nextButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(namaTextBox.Text) || string.IsNullOrEmpty(emailTextBox.Text))
            {
                MessageBox.Show("Nama dan Email harus diisi.");
                return;
            }

            if (jenisComboBox.SelectedItem == null)
            {
                MessageBox.Show("Jenis kamar belum dipilih.");
                return;
            }

            int lamaMenginap = Convert.ToInt32(hariNumericUpDown.Value);
            if (lamaMenginap == 0)
            {
                MessageBox.Show("Hari belum pilih.");
                return;
            }

            int hargaPerMalam = 0;
            if (jenisComboBox.SelectedItem.Equals("Single"))
            {
                hargaPerMalam = 750000;
            }
            else if (jenisComboBox.SelectedItem.Equals("Double"))
            {
                hargaPerMalam = 1000000;
            }
            else if (jenisComboBox.SelectedItem.Equals("Suite"))
            {
                hargaPerMalam = 1500000;
            }

            int totalAmount = hargaPerMalam * lamaMenginap;
            totalLabel.Text = totalAmount.ToString();
            isDataValid = true; // Set flag menjadi true jika semua kondisi terpenuhi
        }
        private void totalLabel_Click(object sender, EventArgs e)
        {

        }

        private void pesanButton_Click(object sender, EventArgs e)
        {
            if (!isDataValid)
            {
                MessageBox.Show("Pesanan tidak valid. Lakukan pengecekan terlebih dahulu.");
                return;
            }

            if (string.IsNullOrEmpty(namaTextBox.Text) || string.IsNullOrEmpty(emailTextBox.Text))
            {
                MessageBox.Show("Nama dan Email harus diisi.");
                return;
            }

            int lamaMenginap = Convert.ToInt32(hariNumericUpDown.Value);
            if (lamaMenginap == 0)
            {
                MessageBox.Show("Hari belum diinput.");
                return;
            }

            string selectedRoomType = jenisComboBox.SelectedItem.ToString();
            if (selectedRoomType == "Single")
            {
                // Pemesanan kamar tipe Single
                for (int i = 0; i < jmlKmr1; i++)
                {
                    if (status1[i] == "tersedia")
                    {
                        status1[i] = "terisi";
                        MessageBox.Show("Pesanan kamar Single dengan nomor " + noKmr1[i] + " berhasil.");
                        break;
                    }
                }
            }
            else if (selectedRoomType == "Double")
            {
                // Pemesanan kamar tipe Double
                for (int i = 0; i < jmlKmr2; i++)
                {
                    if (status2[i] == "tersedia")
                    {
                        status2[i] = "terisi";
                        MessageBox.Show("Pesanan kamar Double dengan nomor " + noKmr2[i] + " berhasil.");
                        break;
                    }
                }
            }
            else if (selectedRoomType == "Suite")
            {
                // Pemesanan kamar tipe Suite
                for (int i = 0; i < jmlKmr3; i++)
                {
                    if (status3[i] == "tersedia")
                    {
                        status3[i] = "terisi";
                        MessageBox.Show("Pesanan kamar Suite dengan nomor " + noKmr3[i] + " berhasil.");
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Tipe kamar tidak valid.");
            }
            
        }

        //FITUR CEK HARGA KAMAR (informasi Hotel)
        private void btnCek_Click(object sender, EventArgs e)
        {
            if (comboBoxJenisKamar.SelectedItem.Equals("Single"))
            {
                labelInformasiHarga.Text = "750000";
            }
            else if (comboBoxJenisKamar.SelectedItem.Equals("Double"))
            {
                labelInformasiHarga.Text = "1000000";
            }
            else if (comboBoxJenisKamar.SelectedItem.Equals("Suite"))
            {
                labelInformasiHarga.Text = "1500000";
            }
        }
        //FITUR CEK KETERSEDIAN KAMAR
        private void cekKmrButton_Click(object sender, EventArgs e)
        {
            string[,] statusKamarTable1 = new string[jmlKmr1, 2];
            string[,] statusKamarTable2 = new string[jmlKmr2, 2];
            string[,] statusKamarTable3 = new string[jmlKmr3, 2];

            // Inisialisasi dan pengisian nilai pada array statusKamarTable1
            for (int i = 0; i < jmlKmr1; i++)
            {
                if (status1[i] == "tersedia")
                {
                    statusKamarTable1[i, 0] = "Tersedia";
                    statusKamarTable1[i, 1] = "";
                }
                else
                {
                    statusKamarTable1[i, 0] = "Terisi";
                    statusKamarTable1[i, 1] = " ";
                }
            }

            // Inisialisasi dan pengisian nilai pada array statusKamarTable2
            for (int i = 0; i < jmlKmr2; i++)
            {
                if (status2[i] == "tersedia")
                {
                    statusKamarTable2[i, 0] = "Tersedia";
                    statusKamarTable2[i, 1] = "";
                }
                else
                {
                    statusKamarTable2[i, 0] = "Terisi";
                    statusKamarTable2[i, 1] = " ";
                }
            }

            // Inisialisasi dan pengisian nilai pada array statusKamarTable3
            for (int i = 0; i < jmlKmr3; i++)
            {
                if (status3[i] == "tersedia")
                {
                    statusKamarTable3[i, 0] = "Tersedia";
                    statusKamarTable3[i, 1] = "";
                }
                else
                {
                    statusKamarTable3[i, 0] = "Terisi";
                    statusKamarTable3[i, 1] = " ";
                }
            }

            try
            {
                int nomorKamar = int.Parse(cekKmrTextBox.Text);
                if (nomorKamar >= 101 && nomorKamar <= 109)
                {
                    int index = nomorKamar - 101;
                    if (statusKamarTable1[index, 0] == "Tersedia")
                    {
                        statusKmrLabel.Text = "Kamar Tersedia";
                    }
                    else
                    {
                        statusKmrLabel.Text = "Kamar Terisi" + statusKamarTable1[index, 1];
                    }
                }
                else if (nomorKamar >= 201 && nomorKamar <= 209)
                {
                    int index = nomorKamar - 201;
                    if (statusKamarTable2[index, 0] == "Tersedia")
                    {
                        statusKmrLabel.Text = "Kamar Tersedia";
                    }
                    else
                    {
                        statusKmrLabel.Text = "Kamar Terisi" + statusKamarTable2[index, 1];
                    }
                }
                else if (nomorKamar >= 301 && nomorKamar <= 309)
                {
                    int index = nomorKamar - 301;
                    if (statusKamarTable3[index, 0] == "Tersedia")
                    {
                    statusKmrLabel.Text = "Kamar Tersedia";
                    }
                    else
                    {
                        statusKmrLabel.Text = "Kamar Terisi" + statusKamarTable3[index, 1];
                    }
                }
                else
                {
                    statusKmrLabel.Text = "No kamar tidak ada";
                    return;
                }
            }catch (Exception ex)
            {
                statusKmrLabel.Text = "Input Angka!";
            }
        }

        private void statusKmrLabel_Click(object sender, EventArgs e)
        {

        }

        private void cekKmrTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        // Logout
        private void logOutButton_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }
    }
}
