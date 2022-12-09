using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FreeComplaints.User
{
    public partial class addquery : System.Web.UI.Page
    {
        BAL.querybal objcomplaintbal = new BAL.querybal();

        protected void Page_Load(object sender, EventArgs e)
        {
            productid_bind();



            Label6.Text = DateTime.Now.ToLongDateString().ToString();
        }
        public void productid_bind()
        {
            DataTable prod = objcomplaintbal.ProductValues();
            // ddlproduct.DataSource = objcomplaintdal.ProductValues();
            ddlproduct.DataTextField = "Product_name";
            ddlproduct.DataValueField = "Product_id";

            ddlproduct.DataSource = prod;
            ddlproduct.DataBind();
            ddlproduct.Items.Insert(0, new ListItem("-- Select --", "0"));
        }
        protected void btnSend_Click(object sender, EventArgs e)
        {
            objcomplaintbal.productid = Convert.ToInt32(ddlproduct.SelectedValue);
            objcomplaintbal.user_id = Convert.ToInt32(Session["lid"]);
            objcomplaintbal.query = txtBody.Text;
            int i = objcomplaintbal.add_query();
            if (i == 1)
            {
                Response.Write("<script>alert('Query Added Successfully');</script>");
                //ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('" + "Complaint Registered Successfully" + "');");
            }

        }
    }
}