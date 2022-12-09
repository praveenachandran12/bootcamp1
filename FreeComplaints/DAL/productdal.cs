using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FreeComplaints.DAL
{
    public class productdal
    {
        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public productdal()
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
        public int PRODUCTnsert(BAL.productbal obj)
        {
            string qry = "insert into tbl_Product values('" + obj.productname + "','" + obj.productaddress + "')";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }
        public DataTable viewProduct()
        {
            string s = "select * from tbl_Product ";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;



        }
        public int productupdate(BAL.productbal obj)
        {
            string s = "update tbl_Product set Product_name = '" + obj.productname + "',Product_description = '" + obj.productaddress + "'where Product_id = '" + obj.productid + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());

            return cmd.ExecuteNonQuery();
        }
        public int productdelete(BAL.productbal obj)
        {
            string s = "Delete from tbl_Product where Product_id='" + obj.productid + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }
        
        
        


 


        


    }
}