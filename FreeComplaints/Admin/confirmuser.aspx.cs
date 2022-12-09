using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FreeComplaints.Admin
{
    public partial class confirmuser : System.Web.UI.Page
    {
        BAL.RegBal objuserdal = new BAL.RegBal();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            { 
                GridView1.DataSource = objuserdal.viewusers(); 
                GridView1.DataBind();
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            objuserdal.Loginid = id.ToString();
            int i = objuserdal.Confirmuser();
            GridView1.DataSource = objuserdal.viewusers();

            GridView1.DataBind();
        }
    }
}