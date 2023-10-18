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
    public partial class frmHastaDetay : Form
    {
        public frmHastaDetay()
        {
            InitializeComponent();
        }
        public string hastatc;
        veriIslem bgl = new veriIslem();
        private void frmHastaDetay_Load(object sender, EventArgs e)
        {
            lblTc.Text = hastatc;

            //ad soyad çekme işlemleri
            SqlCommand komut = new SqlCommand("select hastaAd,hastaSoyad from Tbl_hasta where hastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAd.Text = dr[0] + " " + dr[1];
            }

            bgl.baglanti().Close();

            randevugecmis();

            //bransları çek
            SqlCommand komut2 = new SqlCommand("select bransAd from Tbl_brans", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

           
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select doktorAD,doktorSoyad from Tbl_doktor where doktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            aktifrandevu();

        }

        private void linkBilgiDüzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmbilgidüzenle fr = new frmbilgidüzenle();
            fr.tckimlikno = lblTc.Text;
            fr.Show();
        }

        private void frmHastaDetay_FormClosing(object sender, FormClosingEventArgs e)
        {
            girisfrm fr = new girisfrm();
            fr.Show();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            lblid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btnRandevu_Click(object sender, EventArgs e)
        {
            if (richSikayet.Text == string.Empty || lblid.Text == "(NULL)")
            {
                MessageBox.Show("RANDEVU SEÇİNİZ YA DA ŞİKAYETİNİZİ YAZINIZ", "UYARI EKRANI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand komut = new SqlCommand("update Tbl_randevu set RandevuDurum=1 , HastaTC=@p1 , hastasikayet=@p2 where RandevuID=@p3", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", lblTc.Text);
                komut.Parameters.AddWithValue("@p2", richSikayet.Text);
                komut.Parameters.AddWithValue("@p3", lblid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("RANDEVU BAŞARI İLE KAYDEDİLDİ", "BİLGİ EKRANI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                aktifrandevu();
                randevugecmis();

               
            }
            
        }
        void randevugecmis() //kod yükünü azaltmak için bu metodu ve bi alttaki metodu tanımladık
        {
            //randevu geçmişi
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Tbl_randevu where HastaTC=" + hastatc, bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        void aktifrandevu()
        {
            //aktif randevu
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_randevu where RandevuBrans='" + cmbBrans.Text + "' and RandevuDoktor='" + cmbDoktor.Text + "' and RandevuDurum=0", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;

        }
    }
}
