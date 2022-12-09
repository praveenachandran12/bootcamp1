using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FreeComplaints.DAL
{
    public class userRegistrationDal
    {
        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        private object obj;

        public userRegistrationDal()
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
        public int USERInsert(BAL.RegBal obj)
        {
            string qry = "insert into tbl_Registration values('" + obj.UserName + "','" + obj.Useraddress + "','" + obj.Userphone + "','" + obj.useremail + "','" + obj.Loginid + "')";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }
        public object userlogin(BAL.RegBal obj)
        {
            Getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into tbl_Login values('" + obj.Username1 + "','" + obj.Password1 + "','user','Not confirmed');select @@IDENTITY";
            object id = cmd.ExecuteScalar();
            return id;
        }
        public int User_login(BAL.RegBal obj)
        {
            string s = "select count(*) from tbl_Login where Username='" + obj.Username1 + "' AND Password='" + obj.Password1 + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            int row = (int)cmd.ExecuteScalar();
            return row;
        }
        public DataTable logincheck(BAL.RegBal obj)
        {
            string s = "select * from tbl_Login where Username='" + obj.Username1 + "' AND Password='" + obj.Password1 + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable viewUSER()
        {
            string s = "select * from tbl_Registration  t inner join tbl_Login l on l.Login_id=t.Login_id where Status='Not confirmed' ";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public int userconfirm(BAL.RegBal obj)
        {
            string s = "update tbl_Login set Status = 'confirmed' where Login_id = '" + obj.Loginid + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }
        public DataTable view_USER(BAL.RegBal obj)
        {
            string s = "select s.*,l.* from tbl_Registration s inner join tbl_Login l on s.Login_id=l.Login_id  WHERE Username='" + obj.Username1 + "' AND Password='" + obj.Password1 + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
    }
}