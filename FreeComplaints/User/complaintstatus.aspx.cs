using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FreeComplaints.User
{
    public partial class complaintstatus : System.Web.UI.Page
    {
        BAL.complaintbal objcomplaintbal = new BAL.complaintbal();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                objcomplaintbal.user_id = Convert.ToInt32(Session["lid"]);
                GridView1.DataSource = objcomplaintbal.viewcomplaintstatus();
                GridView1.DataBind();
            }
        }
    }
}