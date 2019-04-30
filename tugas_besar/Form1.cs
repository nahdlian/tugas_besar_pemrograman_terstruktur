using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace tugas_besar
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            String username = txt1.Text;
            String password = txt2.Text;
            String connectionString = "server = localhost; database = login; uid = root; pwd ='';";
            MySqlConnection cnn = new MySqlConnection(connectionString);
            try
            {
                cnn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM dat_login WHERE username = '" + username + "' && password='" +password+ "'", cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("Gagal Login!");
                }
                else
                {
                    FormMenu fr = new FormMenu();
                    fr.Show();
                    this.Hide();
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi Error");
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
