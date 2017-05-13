using SharedLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CustomerDAL
    {

        private String datosConexion = @"Server=USUARIO-PC\SQLEXPRESS;Database=Factura;Trusted_Connection=True";

        public List<Customer> GetAllCustomer()
        {
            List<Customer> list = new List<Customer>();

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = this.datosConexion;
                con.Open();

                String query = "SELECT idCustomer,firstName,SecondName,firstSurname,SecondSurname,phoneNumber,adress,email,(FirstName + ' ' +firstSurname ) AS name FROM Customer";

                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader lector = cmd.ExecuteReader();

                while (lector.Read())
                {
                    Customer customer = new Customer()
                    {
                        idCustomer = Convert.ToInt32(lector["idCustomer"]),
                        FristName = lector["FirstName"].ToString(),
                        SecondName = lector["SecondName"].ToString(),
                        FirstSurname = lector["FirstSurname"].ToString(),
                        secondSurname = lector["secondSurname"].ToString(),
                        phoneNumber = lector["phoneNumber"].ToString(),
                        adress = lector["adress"].ToString(),
                        email = lector["email"].ToString(),
                        name = lector["name"].ToString()
                    };
                    list.Add(customer);
                }



            }

            return list; 
        }
    }
}
