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
    public partial class doktoBilgiDüzenle : Form

    {
        public doktoBilgiDüzenle()
        {
            InitializeComponent();
        }
        public string dktrtc;
        veriIslem bgl = new veriIslem();


        private void doktoBilgiDüzenle_Load(object sender, EventArgs e)
        {
            mskTC.Text = dktrtc;

            //bransları çek
            SqlCommand komut2 = new SqlCommand("select bransAd from Tbl_brans", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

            SqlCommand komut3 = new SqlCommand("select * from Tbl_doktor Where doktorTC=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", mskTC.Text);
            SqlDataReader dr = komut3.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                txtSifre.Text = dr[3].ToString();
                cmbBrans.Text = dr[4].ToString();

            }

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (txtAd.TextLength <= 2 || txtSoyad.TextLength <= 1 || txtSifre.TextLength <= 5)
            {
                MessageBox.Show("BİLGİLERİ EKSİK GİRDİNİZ\n(AD EN AZ 3 SOYAD EN AZ 2 ŞİFRE EN AZ 6 KARAKTER İÇERMELİDİR)", "UYARI EKRANI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                SqlCommand komut = new SqlCommand("update Tbl_doktor set doktorAD = @p1 , doktorSoyad=@p2 , doktorSifre = @p3 , doktorBrans = @p4 where doktorTC = @p5", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtAd.Text);
                komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", txtSifre.Text);
                komut.Parameters.AddWithValue("@p4", cmbBrans.Text);
                komut.Parameters.AddWithValue("@p5", mskTC.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("KAYIT BAŞARI İLE DÜZENLENDİ", "BİLGİ EKRANI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
