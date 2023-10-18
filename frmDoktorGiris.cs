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
    public partial class frmDoktorGiris : Form
    {
        public frmDoktorGiris()
        {
            InitializeComponent();
        }
        veriIslem bgl = new veriIslem();

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_doktor where doktorTC = @p1 and doktorSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTC.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                doktordetayfrm fr = new doktordetayfrm();
                fr.doktortc = mskTC.Text;
                fr.Show();
                this.Hide();
               
            }
            else
            {
                MessageBox.Show("EKSİK VE YA HATALI GİRİŞ YAPTINIZ", "UYARI EKRANI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmDoktorGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            girisfrm fr = new girisfrm();
            fr.Show();
        }

        private void frmDoktorGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
