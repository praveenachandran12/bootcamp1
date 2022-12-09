using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FreeComplaints.DAL
{
    public class querydal
    {
        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public querydal()
        {
            string conn = ConfigurationManager.ConnectionStrings["rose"].ConnectionString;
            con = new SqlConnection(conn);
            cmd.Connection = con;

        }
        public SqlConnection Getcon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;

        }


        public DataTable Product_list()
        {
            string qry = "select  * from tbl_Product";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            return ds;
        }
        public int addquery(BAL.querybal obj)
        {

            string s = "insert into tbl_qery values('" + obj.user_id + "','" + obj.productid + "','" + obj.query + "','not replied', GETDATE())";

            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }
        public DataTable queryview(BAL.querybal obj)
        {
            string s = "select * from tbl_Registration tb inner join tbl_qery qrt on tb.User_id=qrt.User_id inner join tbl_Product pt on pt.Product_id =qrt.Product_id ";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}