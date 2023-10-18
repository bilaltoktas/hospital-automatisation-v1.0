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
    public partial class hastagiris : Form
    {
        public hastagiris()
        {
            InitializeComponent();
        }
        veriIslem bgl = new veriIslem();

        private void lnkUye_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hastaeklefrm fr = new hastaeklefrm();
            fr.Show();
            
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_hasta where hastaTC = @p1 and hastaSifre = @p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTC.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frmHastaDetay fr = new frmHastaDetay();
                fr.hastatc = mskTC.Text;
                fr.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("KULLANICI ADI VE YA ŞİFRE YANLIŞ", "HATALI GİRİŞ ALGILANDI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bgl.baglanti().Close();
        }

        private void hastagiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            girisfrm fr = new girisfrm();
            fr.Show();
        }

        private void hastagiris_Load(object sender, EventArgs e)
        {

        }
    }
}
