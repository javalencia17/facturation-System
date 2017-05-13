using SharedLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CategoryDAL
    {

        private String datosConexion = @"Server=USUARIO-PC\SQLEXPRESS;Database=Factura;Trusted_Connection=True";

        public int insertCategory(Category category)
        {
            int numCategory = 0;

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = this.datosConexion;
                con.Open();

                string query = "insert into Categories (name) VALUES ('" + category.name + "')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }

            return numCategory;

        }

        public List<Category> listCategory()
        {
            List<Category> lista = new List<Category>();

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = this.datosConexion;
                con.Open();

                string query = "SELECT * FROM Categories";

                SqlCommand cmd = new SqlCommand(query,con);
                SqlDataReader lector = cmd.ExecuteReader();

                while (lector.Read())
                {
                    Category category = new Category()
                    {
                        idCategory = Convert.ToInt32(lector["idCategory"]),
                        name = Convert.ToString(lector["name"])
                    };
                    lista.Add(category);
                }

            }

            return lista;
        }

        public int UpdateCategory(Category category)
        {
            int numCategory = 0;

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = this.datosConexion;
                con.Open();

                String query = "UPDATE Categories  SET name = '"+category.name+"' WHERE idCategory = '"+category.idCategory+"' ";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }

            return numCategory;
        }

        public int DeleteCategory(int idCategory)
        {
            int numCategory = 0;

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = this.datosConexion;
                con.Open();

                string query = "DELETE FROM Categories WHERE idCategory = '"+idCategory+"' ";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }

            return numCategory;
        }
    }
}
