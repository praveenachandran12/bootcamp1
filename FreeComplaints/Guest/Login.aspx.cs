using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FreeComplaints.Guest
{
    public partial class Login : System.Web.UI.Page
    {
        BAL.RegBal objuserdal = new BAL.RegBal();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objuserdal.Username1 = TextBox1.Text;
            objuserdal.Password1 = TextBox2.Text;
            DataTable dt = objuserdal.LoginCheck();
            if (dt.Rows.Count == 1)
            {
                Session["Uname"] = dt.Rows[0]["Username"].ToString();
                Session["lid"] = dt.Rows[0]["Login_id"].ToString();
                if (dt.Rows[0]["Role"].ToString() == "admin")
                    Response.Redirect("../Admin/adminhome.aspx");
                else if (dt.Rows[0]["Role"].ToString() == "user")
                    if (dt.Rows[0]["Status"].ToString() == "confirmed")
                Response.Redirect("../User/userhome.aspx");
                    else
                        Response.Write("<script>alert(' User not verified');</script>");
                else
                    Response.Write("<script>alert('Invalid Credentials');</script>");




            }

        }
    }
}