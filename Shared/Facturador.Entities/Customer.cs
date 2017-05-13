using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLayer
{
    public class Customer
    {
        public int idCustomer { get; set; }

        public string FristName { get; set; }
        public string SecondName { get; set; }
        public string FirstSurname { get; set; }
        public string secondSurname { get; set; }
        public string phoneNumber { get; set; }
        public string adress { get; set; }
        public string email { get; set; }

        public virtual string name { get; set; }

    }

}
