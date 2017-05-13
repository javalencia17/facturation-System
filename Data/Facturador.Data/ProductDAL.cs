using SharedLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public  class ProductDAL
    {
        private String datosConexion = @"Server=USUARIO-PC\SQLEXPRESS;Database=Factura;Trusted_Connection=True";

        public List<Product> GetAllProducts()
        {
            List<Product> lista = new List<Product>();

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = datosConexion;
                con.Open();

                String query = "SELECT * FROM Products";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader lector = cmd.ExecuteReader();

                while (lector.Read())
                {
                    Product product = new Product()
                    {
                        idProduct = Convert.ToInt32(lector["idProduct"]),
                        name = lector["name"].ToString(),
                        reference = lector["reference"].ToString(),
                        price = Convert.ToInt32(lector["price"]),
                        idCategory = Convert.ToInt32(lector["idCategory"])
                        
                    };
                    lista.Add(product);
                }

            }

            return lista;
        }

    }
}
