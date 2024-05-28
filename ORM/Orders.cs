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
        public Users? Customer_id { get; set; }
        public List<Components>? Component_id { get; set; }
        public string? Order_date { get; set; }
        public int Total_price { get; set; }
    }
}
