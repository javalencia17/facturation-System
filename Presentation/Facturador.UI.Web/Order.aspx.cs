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
    public partial class Order : System.Web.UI.Page
    {
        BusisnessVentas negocio = new BusisnessVentas();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.ViewGridView();
                this.fillDdlCustomer();
                this.fillDdlProduct();

            }
        }

        private void fillDdlProduct()
        {
            ddlProduct.DataSource = negocio.GetAllProducts();
            ddlProduct.DataTextField = "name";
            ddlProduct.DataValueField = "idProduct";
            ddlProduct.DataBind();

        }

        private void ViewGridView()
        {
           

            gvOrderDetail.DataSource = negocio.GetAllOrderDetail();
            gvOrderDetail.DataBind();
        }

        private void fillDdlCustomer()
        {
            ddlCustomer.DataSource = negocio.GetAllCustomer();
            ddlCustomer.DataTextField = "name";
            ddlCustomer.DataValueField = "idCustomer";
            ddlCustomer.DataBind();
        }





        protected void gvOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click1(object sender, EventArgs e)
        {
            OrderdetalTMP orderDetail = new OrderdetalTMP
            {
                idProduct = Convert.ToInt32(ddlProduct.SelectedValue),
                quantity = Convert.ToInt32(txtCant.Text)
            };

            negocio.insertOrderDetails(orderDetail);
            txtCant.Text = "";

            this.ViewGridView();

        }

      

        protected void btnClear_Click(object sender, EventArgs e)
        {
            negocio.clearOrderDetailTMP();
            this.ViewGridView();
        }

        protected void gvOrderDetail_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnCreateOrder_Click(object sender, EventArgs e)
        {

        }
    }
}