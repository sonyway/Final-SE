using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SupplymentFacts
{
    class Connection
    {
        public SqlConnection taoketnoi()
        {
            return new SqlConnection(@"Data Source=(local); Initial Catalog= SFP;Integrated Security=True;uid = admin;pwd=admin");
        }
        public DataTable show(string sql)
        {
            SqlConnection sqlConn = taoketnoi();
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDa = new SqlDataAdapter(sql, sqlConn);
            sqlDa.Fill(dt);
            return dt;
        }
        public void capnhat(string sql)
        {
            SqlConnection sqlConn = taoketnoi();
            sqlConn.Open();
            SqlCommand sqlComm = new SqlCommand(sql, sqlConn);
            sqlComm.ExecuteNonQuery();
            sqlComm.Dispose();
            sqlConn.Close();
        }
     
        
        
        
    }
}
