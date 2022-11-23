using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class _2_tier : System.Web.UI.Page
    {
        BAL.DeptBAL objdpt1 = new BAL.DeptBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                DropDownList1.DataSource = objdpt1.GetProduct();
                DropDownList1.DataTextField = "depname";
                DropDownList1.DataValueField = "Depid";
                DropDownList1.DataBind();

                GridView1.DataSource = objdpt1.viewdept();
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objdpt1.Desginationname = TextBox1.Text;
            objdpt1.Depid= int.Parse(DropDownList1.SelectedItem.Value);
            int i = objdpt1.insertdepartment();
            GridView1.DataSource = objdpt1.viewdept();
            GridView1.DataBind();

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = objdpt1.viewdept();
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            TextBox txt = new TextBox();
            txt = (TextBox)GridView1.Rows[e.RowIndex].Cells[0].Controls[0];

            objdpt1.Desid = id.ToString();
            objdpt1.Desginationname = txt.Text;
            int i = objdpt1.updatedept();
            GridView1.EditIndex = -1;
            GridView1.DataSource = objdpt1.viewdept();
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int Id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            
            GridView1.DataSource = objdpt1.viewdept();
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}