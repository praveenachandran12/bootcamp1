using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FreeComplaints.User
{
    public partial class complaint : System.Web.UI.Page
    {
        BAL.complaintbal objcomplaintbal = new BAL.complaintbal();
        int cid;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {



                productid_bind();



                Label6.Text = DateTime.Now.ToLongDateString().ToString();
            }

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

        

        protected void Button1_Click1(object sender, EventArgs e)
        {
            objcomplaintbal.productid = Convert.ToInt32(ddlproduct.SelectedValue);
            objcomplaintbal.user_id = Convert.ToInt32(Session["lid"]);
            objcomplaintbal.complaint = complaint1.Text;
            int i = objcomplaintbal.complaint_reg();
            if (i == 1)
            {
                Response.Write("<script>alert('Complaint Registered Successfully');</script>");
                //ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('" + "Complaint Registered Successfully" + "');");
            }
        }
    }
}