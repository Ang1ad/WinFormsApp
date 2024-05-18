using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.ORM
{
    public class Orders
    {
        public int Id { get; set; }
        public Customers Customer_id { get; set; }
        public string order_date { get; set; }
        public int total_price { get; set; }
        public override string ToString()
        {
            return $"{order_date} | {total_price}";
        }
    }
}
