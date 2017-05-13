using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLayer
{
    public class OrderDetail
    {
        public int idOrderDetail { get; set; }
        public int idOrder { get; set; }
        public int idProduct { get; set; }
        public int quantity { get; set; }

        public virtual string description { get; set; }


    }
}
