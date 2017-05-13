using DataLayer;
using SharedLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusisnessLayer
{
    public class BusisnessVentas
    {
        CategoryDAL cat = new CategoryDAL();
        ProductDAL prod = new ProductDAL();
        CustomerDAL cust = new CustomerDAL();
        OrderDetailDAL orDe = new OrderDetailDAL();

        #region Category

        public int insertCategory(Category categoria)
        {
            return cat.insertCategory(categoria);
        }

        public List<Category> listCategory()
        {
            return cat.listCategory();
        }

        public int updateCategory(Category category)
        {
            return cat.UpdateCategory(category);
        }

        public int deleteCategory(int id)
        {
            return cat.DeleteCategory(id);
        }
        #endregion


        #region Product

        public List<Product> GetAllProducts()
        {
            return prod.GetAllProducts();
        }
        #endregion

        #region Customer

        public List<Customer> GetAllCustomer()
        {
            return cust.GetAllCustomer();
        }


        #endregion

        #region OrderDetail

        public int insertOrderDetails(OrderdetalTMP orderDetail)
        {
            return orDe.insertOrderDetails(orderDetail);
        }

        public List<OrderdetalTMP> GetAllOrderDetail()
        {
            return orDe.GetAllOrderDetail();
        }

        public int clearOrderDetailTMP()
        {
            return orDe.clearOrderDetailTMP();
        }

            #endregion
        }
}
