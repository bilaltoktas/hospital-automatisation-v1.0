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
    public partial class doktordetayfrm : Form
    {
        public doktordetayfrm()
        {
            InitializeComponent();
        }
        public string doktortc;
        veriIslem bgl = new veriIslem();

        private void doktordetayfrm_Load(object sender, EventArgs e)
        {
            lblTC.Text = doktortc;
            SqlCommand komut = new SqlCommand("select doktorAD,doktorSoyad from Tbl_doktor where doktorTC = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAd.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            DataTable dta = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevu where RandevuDurum=1",bgl.baglanti());
            da.Fill(dta);
            dataGridView1.DataSource = dta;
        }

        private void doktordetayfrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            girisfrm fr = new girisfrm();
            fr.Show();
        }

        private void lnkBilgi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            doktoBilgiDüzenle fr = new doktoBilgiDüzenle();
            fr.dktrtc = lblTC.Text;
            fr.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            lblTC2.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            richsikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            SqlCommand komut = new SqlCommand("select hastaAD,hastaSoyad from Tbl_hasta where hastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTC2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                lblAd2.Text = dr[0] + " " + dr[1];
            }
        }

        private void btnDuyuru_Click(object sender, EventArgs e)
        {
            duyuruform fr = new duyuruform();
            fr.Show();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
