using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.ORM
{
    public class Customers
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        /*public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }*/
        public ICollection<Orders> Orders { get; set; }

        public override string ToString()
        {
            //return $"{First_name} {Last_name} | {Address} | {Phone} | ";
            return $"{Login}";
        }
    }
}
