using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp6
{
    class Arac_Kiralama
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-J56BCET\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
        DataTable tablo;

        public DataTable listele(SqlDataAdapter adtr,string sorgu)
        {
            tablo = new DataTable();
            adtr = new SqlDataAdapter(sorgu,baglanti);
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;
        }
    }
    
}
