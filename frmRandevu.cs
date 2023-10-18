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
    public partial class frmRandevu : Form
    {
        public frmRandevu()
        {
            InitializeComponent();
        }

        veriIslem bgl = new veriIslem();
        private void frmRandevu_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_randevu", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
                
                }
    }
}
