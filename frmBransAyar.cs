using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp3
{
    public partial class frmBransAyar : Form
    {
        public frmBransAyar()
        {
            InitializeComponent();
        }
        veriIslem bgl = new veriIslem();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komutekle = new SqlCommand("insert into Tbl_brans (bransAd) values (@p1)", bgl.baglanti());
            komutekle.Parameters.AddWithValue("@p1", txtbransad.Text);
            komutekle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("BRANŞ BİLGİLERİ BAŞARI İLE EKLENDİ", "BİLGİ EKRANI", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //ekleme işleminden sonra datagridi yenleme
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_brans", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        private void frmBransAyar_Load(object sender, EventArgs e)
        {
            // form yüklendiğinde verileri datagride çekme
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_brans",bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;
           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtbransid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtbransad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            SqlCommand komutgüncelle = new SqlCommand("update Tbl_brans set bransAd=@p1 where bransID=@p2", bgl.baglanti());
            komutgüncelle.Parameters.AddWithValue("@p1", txtbransad.Text);
            komutgüncelle.Parameters.AddWithValue("@p2", txtbransid.Text);
            komutgüncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("BRANŞ KAYDI BAŞARI İLE GÜNCELLENMİŞTİR", "BİLGİ EKRANI", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // GÜNCELLEME İŞLEMİ SONRASI DATAGRİDİ YENİLEME
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_brans", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("delete from Tbl_brans where bransID = @p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", txtbransid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("BRANŞ KAYDI BAŞARI İLE SİLİNMİŞTİR", "BİLGİ EKRANI", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // SİLME İŞLEMİNDEN SONRA DATAGRİDİ YENİLEME
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_brans", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }
    }
}
