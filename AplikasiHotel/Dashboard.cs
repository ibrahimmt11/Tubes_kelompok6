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
        // Menggunakan List untuk menggantikan array dan menghindari deklarasi ukuran
        List<int> noKmr1 = new List<int>() { 101, 102, 103, 104, 105, 106, 107, 108, 109 };
        List<int> noKmr2 = new List<int>() { 201, 202, 203, 204, 205, 206, 207, 208, 209 };
        List<int> noKmr3 = new List<int>() { 301, 302, 303, 304, 305, 306, 307, 308, 309 };
        List<string> status1 = new List<string>() { "tersedia", "tersedia", "tersedia", "tersedia", "tersedia", "tersedia", "tersedia", "tersedia", "tersedia" };
        List<string> status2 = new List<string>() { "tersedia", "tersedia", "tersedia", "tersedia", "tersedia", "tersedia", "tersedia", "tersedia", "tersedia" };
        List<string> status3 = new List<string>() { "tersedia", "tersedia", "tersedia", "tersedia", "tersedia", "tersedia", "tersedia", "tersedia", "tersedia" };
        int jmlKmr1 = 9;
        int jmlKmr2 = 9;
        int jmlKmr3 = 9;

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
            // Memeriksa apakah nama dan email telah diisi
            if (string.IsNullOrEmpty(namaTextBox.Text) || string.IsNullOrEmpty(emailTextBox.Text))
            {
                MessageBox.Show("Nama dan Email harus diisi.");
                return;
            }

            // Memeriksa apakah jenis kamar telah dipilih
            if (jenisComboBox.SelectedItem == null)
            {
                MessageBox.Show("Jenis kamar belum dipilih.");
                return;
            }

            // Memeriksa lama menginap
            int lamaMenginap = Convert.ToInt32(hariNumericUpDown.Value);
            if (lamaMenginap == 0)
            {
                MessageBox.Show("Hari belum dipilih.");
                return;
            }

            // Menentukan harga per malam berdasarkan jenis kamar
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

            // Menghitung total jumlah yang harus dibayarkan
            int totalAmount = hargaPerMalam * lamaMenginap;
            totalLabel.Text = totalAmount.ToString();

            isDataValid = true; // Set flag menjadi true jika semua kondisi terpenuhi
        }

        private void totalLabel_Click(object sender, EventArgs e)
        {

        }

        private void pesanButton_Click(object sender, EventArgs e)
        {

            // Memeriksa validitas data
            if (!isDataValid)
            {
                MessageBox.Show("Pesanan tidak valid. Lakukan pengecekan terlebih dahulu.");
                return;
            }

            // Memeriksa apakah nama dan email telah diisi
            if (string.IsNullOrEmpty(namaTextBox.Text) || string.IsNullOrEmpty(emailTextBox.Text))
            {
                MessageBox.Show("Nama dan Email harus diisi.");
                return;
            }

            // Memeriksa lama menginap
            int lamaMenginap = Convert.ToInt32(hariNumericUpDown.Value);
            if (lamaMenginap == 0)
            {
                MessageBox.Show("Hari belum diinput.");
                return;
            }

            // Mendapatkan tipe kamar yang dipilih
            string selectedRoomType = jenisComboBox.SelectedItem.ToString();
            bool roomFound = false;

            // Memproses pemesanan berdasarkan tipe kamar yang dipilih
            if (selectedRoomType == "Single")
            {
                // Pemesanan kamar tipe Single
                for (int i = 0; i < jmlKmr1; i++)
                {
                    if (status1[i] == "tersedia")
                    {
                        status1[i] = "terisi";
                        MessageBox.Show("Pesanan kamar Single dengan nomor " + noKmr1[i] + " berhasil.");
                        roomFound = true;
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
                        roomFound = true;
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
                        roomFound = true;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Tipe kamar tidak valid.");
                return;
            }

            // Memeriksa apakah kamar tersedia
            if (!roomFound)
            {
                MessageBox.Show("Kamar sudah penuh.");
            }

            // Mengosongkan pengisian
            namaTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            hariNumericUpDown.Value = 0;
            jenisComboBox.SelectedIndex = -1;
            totalLabel.Text = string.Empty;
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
            try
            {
                // Mengambil nomor kamar dari input teks
                int nomorKamar = int.Parse(cekKmrTextBox.Text);

                string statusKamar = string.Empty;

                // Memeriksa nomor kamar pada setiap tipe kamar
                if (noKmr1.Contains(nomorKamar))
                {
                    // Mengambil indeks kamar pada tipe kamar 1
                    int index = noKmr1.IndexOf(nomorKamar);
                    // Mendapatkan status kamar
                    statusKamar = status1[index];
                }
                else if (noKmr2.Contains(nomorKamar))
                {
                    // Mengambil indeks kamar pada tipe kamar 2
                    int index = noKmr2.IndexOf(nomorKamar);
                    // Mendapatkan status kamar
                    statusKamar = status2[index];
                }
                else if (noKmr3.Contains(nomorKamar))
                {
                    // Mengambil indeks kamar pada tipe kamar 3
                    int index = noKmr3.IndexOf(nomorKamar);
                    // Mendapatkan status kamar
                    statusKamar = status3[index];
                }
                else
                {
                    // Jika nomor kamar tidak ditemukan
                    statusKmrLabel.Text = "No kamar tidak ada";
                    return;
                }

                // Menampilkan status kamar berdasarkan nilai statusKamar
                if (statusKamar == "tersedia")
                {
                    statusKmrLabel.Text = "Kamar Tersedia";
                }
                else if (statusKamar == "terisi")
                {
                    statusKmrLabel.Text = "Kamar Terisi";
                }
            }
            catch (Exception ex)
            {
                // Jika input tidak valid (bukan angka)
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
