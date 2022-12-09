using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FreeComplaints.Admin
{
    public partial class productadd : System.Web.UI.Page
    {
        BAL.productbal objuserdal = new BAL.productbal();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = objuserdal.viewproduct();
                GridView1.DataBind();
            }
        }
    

    protected void Button1_Click(object sender, EventArgs e)
    {
        objuserdal.productname = TextBox1.Text;
        objuserdal.productaddress = TextBox2.Text;
        int i = objuserdal.productinsert();
        GridView1.DataSource = objuserdal.viewproduct();
            GridView1.DataBind();


        }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
        objuserdal.productid = id;
        int i = objuserdal.Deleteproduct();
            GridView1.EditIndex = -1;

            GridView1.DataSource = objuserdal.viewproduct();


            GridView1.DataBind();
        }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        GridView1.DataSource = objuserdal.viewproduct();


        GridView1.DataBind();
    }

    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
        TextBox TextBox1 = new TextBox();
            TextBox1 = (TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0];
            TextBox TextBox2 = new TextBox();
        
        TextBox2 = (TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0];
        objuserdal.productid = id;
        objuserdal.productname = TextBox1.Text;
        objuserdal.productaddress = TextBox2.Text;
        int i = objuserdal.updateproduct();

        GridView1.EditIndex = -1;

        GridView1.DataSource = objuserdal.viewproduct();


        GridView1.DataBind();

    }

    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
          {
            GridView1.EditIndex = -1;
            GridView1.DataSource = objuserdal.viewproduct();
            GridView1.DataBind();

        }
  }
}