using SharedLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class OrderDetailDAL
    {

        private String datosConexion = @"Server=USUARIO-PC\SQLEXPRESS;Database=Factura;Trusted_Connection=True";

       

        public int insertOrderDetails(OrderdetalTMP orderDetail)
        {
            int numOrder = 0;

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = this.datosConexion;
                con.Open();


                string query = "INSERT INTO OrderDetailTMP (idProduct, quantity ) VALUES ( '" + orderDetail.idProduct + "' , '" + orderDetail.quantity + "') ";

                

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();

            }

            return numOrder;
        }

        public List<OrderdetalTMP> GetAllOrderDetail()
        {
            List<OrderdetalTMP> lista = new List<OrderdetalTMP>();

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = this.datosConexion;
                con.Open();

                String query = "SELECT O.idOrderDetail , O.idProduct , O.quantity, P.name AS description , P.price AS total FROM OrderDetailTMP O, Products P WHERE O.idProduct = P.idProduct";

                SqlCommand cmd = new SqlCommand(query,con);

                SqlDataReader lector = cmd.ExecuteReader();

                while (lector.Read())
                {
                    OrderdetalTMP orderDetail = new OrderdetalTMP()
                    {
                        idOrderDetail = Convert.ToInt32(lector["idOrderDetail"]),
                        idProduct = Convert.ToInt32(lector["idProduct"]),
                        quantity = Convert.ToInt32(lector["quantity"]),
                        description = lector["description"].ToString(),
                        subtotal = Convert.ToInt32(lector["total"])
                        
                    };
                    lista.Add(orderDetail);
                }
            }

            return lista;
        }


        public int clearOrderDetailTMP()
        {
            int num = 0;

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = this.datosConexion;
                con.Open();

                string query = "TRUNCATE TABLE OrderDetailTMP ";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();

            }

            return num;
        }





    }
}
