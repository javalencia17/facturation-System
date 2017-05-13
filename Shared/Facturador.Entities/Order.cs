using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLayer
{
    public class Order
    {

        public int idOrder { get; set; }
        public int idCustomer { get; set; }
        public DateTime date { get; set; }

        public string state { get; set; }

    }
}
