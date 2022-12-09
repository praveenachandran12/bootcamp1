using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FreeComplaints.Guest
{
    public partial class userregistration : System.Web.UI.Page
    {
        BAL.RegBal objuserdal = new BAL.RegBal();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objuserdal.UserName = USERNAME.Text;
            objuserdal.Useraddress = USERADDRESS.Text;
            objuserdal.Userphone = USERPHONE.Text;
            objuserdal.useremail = USEREMAIL.Text;
            objuserdal.Username1 = User1.Text;
            objuserdal.Password1 = passoword1.Text;
            object ob = objuserdal.user_login_insert();
            objuserdal.Loginid = ob;
            int i = objuserdal.userdepartment();
            

            Response.Redirect("https://localhost:44314/Guest/Default.aspx");
            Response.Write("Your Registration is successful");

        }
    }
}