using BusisnessLayer;
using SharedLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Facturador.UI.Web
{
    public partial class categoria : System.Web.UI.Page
    {
        BusisnessVentas negocio = new BusisnessVentas();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                this.fillBind();
            }

        }

        private void fillBind()
        {
            gvCategory.DataSource = negocio.listCategory();
            gvCategory.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

            Category category = new Category()
            {
                name = ((TextBox)gvCategory.FooterRow.FindControl("txtName")).Text
            };
            negocio.insertCategory(category);
            ((TextBox)gvCategory.FooterRow.FindControl("txtName")).Text = "";
            this.fillBind();

        }

        protected void gvCategory_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvCategory.EditIndex = e.NewEditIndex;
            this.fillBind();
        }

        protected void gvCategory_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {


            Category category = new Category()
            {
                idCategory = Convert.ToInt32(((Label)gvCategory.Rows[e.RowIndex].FindControl("lblId")).Text),
                name = ((TextBox)gvCategory.Rows[e.RowIndex].FindControl("txtNameUp")).Text
            };

            negocio.updateCategory(category);
            gvCategory.EditIndex = -1;
            this.fillBind();
        }

        protected void gvCategory_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(((Label)gvCategory.Rows[e.RowIndex].FindControl("Label1")).Text);
            negocio.deleteCategory(id);
            this.fillBind();
        }

        protected void gvCategory_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvCategory.EditIndex = -1;
            this.fillBind();
        }

        protected void gvCategory_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvCategory.PageIndex = e.NewPageIndex;
            this.fillBind();
        }

        protected void gvCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}