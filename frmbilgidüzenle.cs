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
    public partial class frmbilgidüzenle : Form
    {
        public frmbilgidüzenle()
        {
            InitializeComponent();
        }
        public string tckimlikno;
        veriIslem bgl = new veriIslem();

        private void frmbilgidüzenle_Load(object sender, EventArgs e)
        {
            mskTC.Text = tckimlikno;
            SqlCommand komut = new SqlCommand("select * from Tbl_hasta where hastaTC=@p1 ",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                mskTelefon.Text = dr[4].ToString();
                cmbCinsiyet.Text = dr[6].ToString();
                txtSifre.Text = dr[5].ToString();
            }

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Tbl_hasta set hastaAd = @p1,hastaSoyad=@p2,hastaTelefon = @p3,hastaSifre = @p4 , hastaCinsiyet = @p5 where hastaTC = @p6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", txtAd.Text);
            komut2.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", mskTelefon.Text);
            komut2.Parameters.AddWithValue("@p4", txtSifre.Text);
            komut2.Parameters.AddWithValue("@p5", cmbCinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", mskTC.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("BİLGİ GÜNCELLEME İŞLEMİNİZ TAMAMLANMIŞTIR", "BİLGİ EKRANI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
