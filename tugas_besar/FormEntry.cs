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
    public partial class FormEntry : Form
    {
        public FormEntry()
        {
            InitializeComponent();
        }

        MahasiswaDAO md = new MahasiswaDAO();

        void lihatSemua() {
            DataSet data = md.getData();
            dataGridView1.DataSource = data;
            dataGridView1.DataMember = "db_mhs";

        }
       
        private void FormEntry_Load(object sender, EventArgs e)
        {
            lihatSemua();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNim.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNama.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtProdi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSmstr.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtTahun.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

            nim = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Mahasiswa m = new Mahasiswa();

            m.Nim = txtNim.Text;
            m.Nama = txtNama.Text;
            m.Prodi = txtProdi.Text;
            m.Semester = txtSmstr.Text;
            m.Tahun = txtTahun.Text;
            md.InsertData(m);
            lihatSemua();
        }

        string nim;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Mahasiswa m = new Mahasiswa();

            m.Nim = txtNim.Text;
            m.Nama = txtNama.Text;
            m.Prodi = txtProdi.Text;
            m.Semester = txtSmstr.Text;
            m.Tahun = txtTahun.Text;
            md.updateData(m, nim);
            lihatSemua();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNama.Clear();
            txtNim.Clear();
            txtProdi.Clear();
            txtSmstr.Clear();
            txtTahun.Clear();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            md.deleteData(nim);
            lihatSemua();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMenu fe = new FormMenu();
            fe.Show();
            this.Hide();
        }
    }
}
