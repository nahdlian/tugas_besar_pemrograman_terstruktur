using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace tugas_besar
{
    class MahasiswaDAO
    {
        private MySqlCommand perintah = null;

        string config = "Server = localhost; database = mahasiswa; uid =root; pwd =;";

        MySqlConnection conn = new MySqlConnection();

        public MahasiswaDAO() {
            conn.ConnectionString = config;
        }

        public DataSet getData()
        {
            DataSet ds = new DataSet();

            try
            {
                conn.Open();
                perintah = new MySqlCommand();
                perintah.Connection = conn;
                perintah.CommandType = CommandType.Text;
                perintah.CommandText = "SELECT nim, nama, prodi, smstr, angkatan FROM db_mhs";
                MySqlDataAdapter mds = new MySqlDataAdapter(perintah);
                mds.Fill(ds, "db_mhs");
                conn.Close();

            }
            catch (MySqlException)
            {
            }
            return ds;
        }

        public bool InsertData(Mahasiswa m)
        {

            Boolean stat = false;

            try
            {
                conn.Open();
                perintah = new MySqlCommand();
                perintah.Connection = conn;
                perintah.CommandType = CommandType.Text;
                perintah.CommandText = "INSERT INTO db_mhs VALUES ('" + m.Nim + "','" + m.Nama + "','" + m.Prodi + "','"+m.Semester+"','" + m.Tahun + "')";
                perintah.ExecuteNonQuery();

                stat = true;
                conn.Close();

            }
            catch (MySqlException)
            {
                
            }
            return stat;
        }

            public bool deleteData(string nim)
        {
            Boolean stat = false;
            try
            {
                conn.Open();
                perintah = new MySqlCommand();
                perintah.Connection = conn;
                perintah.CommandType = CommandType.Text;
                perintah.CommandText = "DELETE  FROM db_mhs WHERE nim='" + nim + "'";
                perintah.ExecuteNonQuery();
                stat = true;
                conn.Close();
            }
            catch (MySqlException) {
            }
            return stat;
        }

        public bool updateData(Mahasiswa m,string nim) {
            Boolean stat = false;
            try
            {
                conn.Open();
                perintah = new MySqlCommand();
                perintah.Connection = conn;
                perintah.CommandType = CommandType.Text;
                perintah.CommandText = "UPDATE db_mhs SET nim= '" + m.Nim + "', nama='" + m.Nama + "', prodi='" + m.Prodi + "', smstr='" + m.Semester + "', angkatan = '"+m.Tahun+"' WHERE nim='"+m.Nim+"'"; 
                perintah.ExecuteNonQuery();
                stat = true;
                conn.Close();
            }
            catch (MySqlException) { }
            return stat;

           }
        }
    }
    

