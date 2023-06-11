using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiHotel
{
    public partial class Dashboard : Form
    {
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
    }
}
