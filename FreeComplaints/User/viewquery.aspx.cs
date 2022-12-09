using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FreeComplaints.User
{
    public partial class viewquery : System.Web.UI.Page
    {
        BAL.querybal objcomplaintbal = new BAL.querybal();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = objcomplaintbal.viewquery();
            GridView1.DataBind();
        }

       
    }
}