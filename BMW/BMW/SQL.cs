using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BMW
{
    class SQL
    {
      
        SqlConnection bag_cumle = new SqlConnection( "Data Source=OZEN; Initial Catalog=BMW;Integrated Security=true");
        SqlDataAdapter adapter;
        public DataTable tablo=new DataTable();
        private void baglan(int secim)
        {
            if (secim == 1)
            {
                if (bag_cumle.State == ConnectionState.Closed)
                {
                    bag_cumle.Open();
                }
            }
            else if (secim == 0)
            {
                bag_cumle.Close();
            }
        }
        public void Select(string sorgu)
        {
            baglan(1);
            adapter = new SqlDataAdapter(sorgu,bag_cumle);
            adapter.Fill(tablo);
            baglan(0);
        }
    }
}
