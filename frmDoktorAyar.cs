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
    public partial class frmDoktorAyar : Form
    {
        public frmDoktorAyar()
        {
            InitializeComponent();
        }
        veriIslem bgl = new veriIslem();

        private void frmDoktorAyar_Load(object sender, EventArgs e)
        {

            //branşları comboboxa çekme
            SqlCommand komutcmb = new SqlCommand("select bransAd from Tbl_brans", bgl.baglanti());
            SqlDataReader dr = komutcmb.ExecuteReader();
            while (dr.Read())
            {
                cmbBranş.Items.Add(dr[0]);
            }
            //doktorları listeye ekleme 
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from Tbl_doktor", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_doktor (doktorAD,doktorSoyad,doktorBrans,doktorTC,doktorSifre) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbBranş.Text);
            komut.Parameters.AddWithValue("@p4", mskTCkimlik.Text);
            komut.Parameters.AddWithValue("@p5", txtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("DOKTOR BAŞARI İLE EKLENDİ", "BİLGİ EKRANI", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //ekleme işleminden sonra datagridi yenileme işlemi
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from Tbl_doktor", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            if (mskTCkimlik.Text==string.Empty && txtSifre.Text==string.Empty)
            {
                MessageBox.Show("BİLGİLER EKSİK GİRİLEMEZ", "UYARI EKRANI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                SqlCommand komut2 = new SqlCommand("Update Tbl_doktor set doktorAD=@p1,doktorSoyad=@p2,doktorBrans=@p3 ,doktorSifre=@p4 where doktorTC=@p5", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p5", mskTCkimlik.Text);
                komut2.Parameters.AddWithValue("@p1", txtAd.Text);
                komut2.Parameters.AddWithValue("@p2", txtSoyad.Text);
                komut2.Parameters.AddWithValue("@p3", cmbBranş.Text);
                komut2.Parameters.AddWithValue("@p4", txtSifre.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("DOKTOR BİLGİLERİ BAŞARI İLE GÜNCELLENDİ", "BİLGİ EKRANI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //düzenleme işleminden sonra datagridi yenileme işlemi
                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter("select * from Tbl_doktor", bgl.baglanti());
                da2.Fill(dt2);
                dataGridView1.DataSource = dt2;


            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text= dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbBranş.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskTCkimlik.Text= dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("delete from Tbl_doktor where doktorTC =@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", mskTCkimlik.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("DOKTOR BİLGİLERİ BAŞARI İLE SİLİNDİ", "BİLGİ EKRANI", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //silme işleminden sonra datagridi yenileme işlemi
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from Tbl_doktor", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }
    }
}
