using SharedLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public  class OrderDAL
    {
        private String datosConexion = @"Server=USUARIO-PC\SQLEXPRESS;Database=Factura;Trusted_Connection=True";

        public int TransOrder(Order order,OrderDetail orderDetail)
        {
            int numtran = 0;

            using (SqlConnection con = new SqlConnection())
            {
                SqlTransaction transaction;

                con.ConnectionString = this.datosConexion;
                con.Open();

                transaction = con.BeginTransaction();

                try
                {
                    new SqlCommand("INSERT INTO (idCustomer,date,state)"+
                        "VALUES ('"+order.idCustomer+"','"+DateTime.Now+"','"+order.state+"')", con,transaction)
                        .ExecuteNonQuery();
                    
                    new SqlCommand("INSERT INTO OrderDetails (idOrder,idProduct,quantity) "+
                        "SELECT O.idOrder, D.idProduct, D.quantity FROM OrderDetailTMP D, Orders O ", con, transaction).ExecuteNonQuery();
                  


                }
                catch (SqlException sqlError)
                {
                    transaction.Rollback();
                }


                
            }

            return numtran;
        }

    }
}
