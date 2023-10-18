using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    class veriIslem
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source = BilalT; Initial Catalog = hastaneOtomasyon; Integrated Security = True");
            baglan.Open();
            return baglan;
        }
    }
}
