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
    public partial class sekretergiris : Form
    {
        public sekretergiris()
        {
            InitializeComponent();
        }
        veriIslem bgl = new veriIslem();

        private void sekretergiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            girisfrm fr = new girisfrm();
            fr.Show();
        }

        private void sekretergiris_Load(object sender, EventArgs e)
        {
            mskTC.Focus();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_sekreter where sekreterTC=@p1 and sekreterSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTC.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                sekreterdetay fr = new sekreterdetay();
                fr.sekreterTc = mskTC.Text;
                fr.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("TC KİMLİK NO VE YA ŞİFRE HATALI GİRİLDİ", "HATALI GİRİŞ ALGILANDI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bgl.baglanti().Close();
        }
    }
}
