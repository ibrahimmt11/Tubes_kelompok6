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
    }
}
