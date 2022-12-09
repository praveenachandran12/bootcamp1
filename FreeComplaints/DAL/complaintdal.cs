using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FreeComplaints.DAL
{

    public class complaintdal
    {
        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public complaintdal()
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
        public DataTable ProductValues(int productid)
        {

            string qry = "select  * from tbl_Product";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable(); 
            //cmd.ExecuteNonQuery(); 
            da.Fill(ds); 
            return ds;
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

        public int complaintReg(BAL.complaintbal obj)
        {

            string s = "insert into tbl_Complaint values('" + obj.user_id + "','" + obj.productid + "', GETDATE() ,'" + obj.complaint + "','Complaint Received')";

            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }
        public DataTable complaintview(BAL.complaintbal obj)
        {
            string s = "select * from tbl_Registration tb inner join tbl_Complaint cmt on tb.User_id=cmt.User_id inner join tbl_Product pt on pt.Product_id=cmt.Product_id";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int Changecmpltstatus(BAL.complaintbal obj)
        {
            string s = "update tbl_Complaint set C_status='Complaint Confirmed' where Complaint_id='" + obj.ComplaintId + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }

        public DataTable Viewcomplaintstatus(BAL.complaintbal obj)
        {
            string s = "select * from tbl_Registration tb inner join tbl_Complaint cmt on tb.User_id=cmt.User_id inner join tbl_Product pt on pt.Product_id=cmt.Product_id where cmt.User_id='" + obj.user_id + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}