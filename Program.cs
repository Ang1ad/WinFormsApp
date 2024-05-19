using Microsoft.EntityFrameworkCore;
using WinFormsApp.ORM;

namespace WinFormsApp
{
    #region ORM
    internal static class Program
    {
        static IEnumerable<Customers> CreateFakeData()
        {
            var customers = new List<Customers>
            {
                new Customers
                {
                    Login = "login", Password = "password", Orders = new List<Orders>
                    {
                        new Orders {order_date = "10.10.2022", total_price = 20000},
                        new Orders {order_date = "22.03.2024", total_price = 450000}
                    }
                },
                new Customers
                {
                    Login = "login1", Password = "password1", Orders= new List<Orders>
                    {
                        new Orders {order_date = "20.05.2023", total_price = 10000000},
                        new Orders {order_date = "15.05.2024", total_price = 100000000}
                    }
                }
            };

            return customers;
        }
        #endregion

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*var options = new DbContextOptionsBuilder<OrdersContext>()
                .UseSqlite("Filename=../../../MyLocalLibrary.db")
                .Options;

            using var db = new OrdersContext(options);

            db.Database.EnsureCreated();*/

            /*var customers = CreateFakeData();

            db.Customers.AddRange(customers);

            db.SaveChanges();*/

            /*foreach (var customer in db.Customers.Include(c => c.Orders))
            {
                Console.WriteLine($"{customer} ordered ");
                foreach (var orders in customer.Orders)
                {
                    Console.WriteLine($"{orders}");
                }
            }*/
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Auth());
        }
    }
}