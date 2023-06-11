using System;
using System.IO;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AplikasiHotel
{
    public partial class LoginPage : Form
    {
        private Config config;
        private string path;
        private string configFileName;
        public LoginPage()
        {
            InitializeComponent();
            path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            configFileName = "Login_config.json";

            try
            {
                ReadConfig();
            }
            catch
            {
                SetDefault();
                WriteConfig();
            }
        }

        private void ReadConfig()
        {
            string jsonFromFile = File.ReadAllText(Path.Combine(path, configFileName));
            config = JsonSerializer.Deserialize<Config>(jsonFromFile);
        }

        private void WriteConfig()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(config, options);
            string fullPath = Path.Combine(path, configFileName);
            File.WriteAllText(fullPath, jsonString);
        }
        private void SetDefault()
        {
            config = new Config("admin", "password123", "Login sukses", "Login gagal");
        }
        public class Config
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public string Login_sukses { get; set; }
            public string Login_gagal { get; set; }

            public Config() { }

            public Config(string Username, string Password, string Login_sukses, string Login_gagal)
            {
                this.Username = Username;
                this.Password = Password;
                this.Login_sukses = Login_sukses;
                this.Login_gagal = Login_gagal;
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Input tidak boleh kosong");
                return;
            }

            if (config.Username == username && config.Password == password)
            {
                Dashboard ds = new Dashboard();
                ds.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(config.Login_gagal);
            }
        }

        private void LoginPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
