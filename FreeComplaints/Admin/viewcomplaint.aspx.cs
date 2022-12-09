using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FreeComplaints.Admin
{
    public partial class viewcomplaint : System.Web.UI.Page
    {
        BAL.complaintbal objcomplaintbal = new BAL.complaintbal();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = objcomplaintbal.viewcomplaint();
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            objcomplaintbal.ComplaintId = id;
            int i = objcomplaintbal.changecmpltstatus();
            GridView1.DataSource = objcomplaintbal.viewcomplaint();
            GridView1.DataBind();
        }
    }
}