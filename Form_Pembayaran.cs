using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JenisBayar
{
    public partial class Form_JenisPembayaran : Form
    {

        // deklarasi koneksi string 
        private string conStr = "Data Source=JENNNN\\SQLEXPRESS; " +
            "Initial Catalog=dbAdmSekolah; Integrated Security=True";
        private SqlConnection sqlCon;
        public Form_JenisPembayaran()
        {
            InitializeComponent();
            sqlCon = new SqlConnection(conStr);
        }

        private void Form_Agama_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbAdmSekolahDataSet.tbl_JenisBayar' table. You can move, or remove it, as needed.
            //  this.tbl_JenisBayarTableAdapter.Fill(this.dbAdmSekolahDataSet.tbl_JenisBayar);
            tampilDataJenisBayar();

        }

        private void tampilDataJenisBayar()
        {
            sqlCon.Open();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM tbl_JenisBayar";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(sqlCmd);
            sda.Fill(ds, "tbl_JenisBayar");
            dgJenisBayar.DataSource = ds;
            dgJenisBayar.DataMember = "tbl_JenisBayar";
            sqlCon.Close();
        }

        private void ClearData()
        {
            txtKodePembayaran.Clear();
            txtNamaPembayaran.Clear();
            txtJumlahPembayaran.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();    
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "INSERT INTO tbl_JenisBayar (kode_jenispembayaran, nama_pembayaran, jml_pembayaran) VALUES (@kode_jenispembayaran, @nama_pembayaran, @jml_pembayaran)";
            cmd.Parameters.AddWithValue("@kode_jenispembayaran", txtKodePembayaran.Text);
            cmd.Parameters.AddWithValue("@nama_pembayaran", txtNamaPembayaran.Text);
            cmd.Parameters.AddWithValue("@jml_pembayaran", txtJumlahPembayaran.Text);

            cmd.ExecuteNonQuery();
            sqlCon.Close();

            tampilDataJenisBayar();
            ClearData();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "UPDATE tbl_JenisBayar SET nama_pembayaran = @nama_pembayaran, jml_pembayaran = @jml_pembayaran WHERE kode_jenispembayaran = @kode_jenispembayaran";
            cmd.Parameters.AddWithValue("@kode_jenispembayaran", txtKodePembayaran.Text);
            cmd.Parameters.AddWithValue("@nama_pembayaran", txtNamaPembayaran.Text);
            cmd.Parameters.AddWithValue("@jml_pembayaran", txtJumlahPembayaran.Text);

            cmd.ExecuteNonQuery();
            sqlCon.Close();

            tampilDataJenisBayar();
            ClearData();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "DELETE FROM tbl_JenisBayar WHERE kode_jenispembayaran = @kode_jenispembayaran";
            cmd.Parameters.AddWithValue("@kode_jenispembayaran", txtKodePembayaran.Text);

            cmd.ExecuteNonQuery();
            sqlCon.Close();

            tampilDataJenisBayar();
            ClearData();
        }
    }
}
