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
    public partial class sekreterdetay : Form
    {
        public sekreterdetay()
        {
            InitializeComponent();
        }

        private void sekreterdetay_FormClosing(object sender, FormClosingEventArgs e)
        {
            girisfrm fr = new girisfrm();
            fr.Show();
        }

        public string sekreterTc = null;
        veriIslem bgl = new veriIslem();
        private void sekreterdetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = sekreterTc;

            //ad soyad verilerini çekme
            SqlCommand komut1 = new SqlCommand("select sekreterAd , sekreterSoyad from Tbl_sekreter where sekreterTC = @p1 ",bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblAd.Text = (dr1[0].ToString() + " " + dr1[1].ToString());
            }
            bgl.baglanti().Close();

            //branşları datagride aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Tbl_brans", bgl.baglanti());
            da1.Fill(dt1);
            dataBranş.DataSource = dt1;

            //doktorları listeye ekleme
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select (doktorAD+' '+doktorSoyad) as Doktorlar,doktorBrans as Branş from Tbl_doktor", bgl.baglanti());
            da2.Fill(dt2);
            dataDoktor.DataSource = dt2;

            //branşları comboboxa çekme
            SqlCommand komut3 = new SqlCommand("select bransAd from Tbl_brans", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbBranş.Items.Add(dr3[0]);
            }
            bgl.baglanti().Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (mskTarih.Text == string.Empty || mskSaat.Text == string.Empty || cmbBranş.Text == string.Empty || cmbDoktor.Text == string.Empty)
            { MessageBox.Show("RANDEVU BİLGİLERİ BOŞ GİRİLEMEZ", "UYARI EKRANI", MessageBoxButtons.OK, MessageBoxIcon.Error);}
            else
            {SqlCommand komut2 = new SqlCommand("insert into Tbl_randevu (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)", bgl.baglanti());
                komut2.Parameters.AddWithValue("@r1", mskTarih.Text);
                komut2.Parameters.AddWithValue("@r2", mskSaat.Text);
                komut2.Parameters.AddWithValue("@r3", cmbBranş.Text);
                komut2.Parameters.AddWithValue("@r4", cmbDoktor.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("RANDEVU BAŞARI İLE OLUŞTURULDU", "BİLGİ EKRANI", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void cmbBranş_SelectedIndexChanged(object sender, EventArgs e)
        {
            //doktorları comboboxa ekleme
            cmbDoktor.Items.Clear();
            SqlCommand komut4 = new SqlCommand("select doktorAD,doktorSoyad from Tbl_doktor where doktorBrans=@p1", bgl.baglanti());
            komut4.Parameters.AddWithValue("@p1", cmbBranş.Text);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                cmbDoktor.Items.Add(dr4[0] + " " + dr4[1]);
            }
        }

        private void btnOluştur_Click(object sender, EventArgs e)
        {
            if (richDuyuru.Text == string.Empty){
                MessageBox.Show("DUYURU METNİ BOŞ OLAMAZ", "UYARI EKRANI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {//duyuru kaydetme
                SqlCommand komut5 = new SqlCommand("insert into Tbl_duyuru (duyuruMetin) values (@p1)", bgl.baglanti());
                komut5.Parameters.AddWithValue("@p1", richDuyuru.Text);
                komut5.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("DUYURU BAŞARI İLE OLUŞTURULDU", "BİLGİ EKRANI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDoktor_Click(object sender, EventArgs e)
        {
            //DOKTOR EKRANINA GEÇİŞ İŞLEMLERİ 
            frmDoktorAyar fr = new frmDoktorAyar();
            fr.Show();
            
        }

        private void btnBranş_Click(object sender, EventArgs e)
        {
            frmBransAyar fr = new frmBransAyar();
            fr.Show();
        }

        private void btnRandevu_Click(object sender, EventArgs e)
        {
            frmRandevu fr = new frmRandevu();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            duyuruform fr = new duyuruform();
            fr.Show();
        }
    }
}
