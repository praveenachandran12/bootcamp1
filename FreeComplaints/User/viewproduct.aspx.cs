using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FreeComplaints.User
{
    public partial class complaintadd : System.Web.UI.Page
    {
        BAL.productbal objuserdal = new BAL.productbal();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = objuserdal.viewproduct();
            GridView1.DataBind();
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://localhost:44314/User/complaint.aspx");
        }
    }
}