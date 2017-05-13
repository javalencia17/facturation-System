using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLayer
{
    public class OrderdetalTMP
    {
        public int idOrderDetail { get; set; }

        public int idProduct { get; set; }
         
        public int quantity { get; set; }

        public int subtotal { get; set; }

        public virtual String description { get; set; }

      

    }
}
