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

namespace AplikasiHotel
{
    public partial class Dashboard : Form
    {
        public int totalAmount = 0;
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

        private void label21_Click(object sender, EventArgs e)
        {
            string menuText = "Menu Makanan Tersedia:\n";

            foreach (var menuItem in menuMakanan)
            {
                menuText += $"{menuItem.Key}. {menuItem.Value}\n";
            }

            label2.Text = menuText;
        }

        private void btnPesan_Click(object sender, EventArgs e)
        {
            int nomorMakanan;
            if (int.TryParse(inputmakanan.Text, out nomorMakanan))
            {
                // Mengecek apakah nomor makanan ada dalam daftar menu
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

        private void jenisComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (jenisComboBox.SelectedItem.Equals("Single"))
            {
                totalAmount = 750000;
                floorComboBox.SelectedItem = "1";
            }
            else if (jenisComboBox.SelectedItem.Equals("Double"))
            {
                totalAmount = 1000000;
                floorComboBox.SelectedItem = "2";
            }
            else if (jenisComboBox.SelectedItem.Equals("Suite"))
            {
                totalAmount = 1500000;
                floorComboBox.SelectedItem = "3";
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            int lamaMenginap = Convert.ToInt32(hariNumericUpDown.Value);
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

            labelTotalHarga.Text = totalAmount.ToString();
        }

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

        private void logOutButton_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }
    }
}
