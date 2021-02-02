using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdvanceProject1
{
    class sql
    {
        public SqlConnection connection()
        {
            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-U2S06HR\\SQLEXPRESS;Initial Catalog=BookStoreDatabase;Integrated Security=True");
            connect.Open();
            return connect;
        }
    }
}
