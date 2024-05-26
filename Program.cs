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
            var options = new DbContextOptionsBuilder<OrdersContext>()
                .UseSqlite("Filename=../../../MyLocalLibrary.db")
                .Options;

            using var db = new OrdersContext(options);

            db.Database.EnsureCreated();

            var customers = CreateFakeData();

            db.Customers.AddRange(customers);

            db.SaveChanges();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Auth());
        }
    }
}