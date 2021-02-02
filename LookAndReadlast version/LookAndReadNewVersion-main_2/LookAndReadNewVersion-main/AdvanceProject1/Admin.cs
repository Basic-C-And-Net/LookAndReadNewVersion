using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdvanceProject1
{
    class Admin : ILogin
    {
        sql bgl = new sql();
        string username;
        string password;
        bool isLogin2;
        public bool Login()
        {
            SqlCommand command = new SqlCommand("select * from Tbl_admin where AdminUsername=@p1 and AdminPassword=@p2", bgl.connection());
            command.Parameters.AddWithValue("@p1", username);
            command.Parameters.AddWithValue("@p2", password);
            SqlDataReader dr = command.ExecuteReader();
            isLogin2 = dr.Read();
            return isLogin2;

        }
        public string GetUsername()
        {
            return username;
        }
        public void SetUsername(string username)
        {
            this.username = username;
        }
        public string GetPassword()
        {
            return password;
        }
        public void SetPassword(string password)
        {
            this.password = password;
        }
    }
}
