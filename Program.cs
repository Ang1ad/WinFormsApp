namespace WinFormsApp
{
    internal static class Program
    {
        static IEnumerable<Customers> CreateFakeData()
        {
            var customers = new List<Customers>
            {
                new Customers
                {
                    First_name = "John", Last_name = "Harris", Address = "London", Phone = "8800", Orders = new List<Orders>
                    {
                        new Orders {order_date = "10.10.2022", total_price = 20000},
                        new Orders {order_date = "22.03.2024", total_price = 450000}
                    }
                },
                new Customers
                {
                    First_name = "Elon", Last_name = "Musk", Address = "Florida", Phone = "123456", Orders= new List<Orders>
                    {
                        new Orders {order_date = "20.05.2023", total_price = 10000000},
                        new Orders {order_date = "15.05.2024", total_price = 100000000}
                    }
                }
            };

            return customers;
        }







        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var customers = CreateFakeData();
            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer} ordered ");
                foreach (var orders in customer.Orders)
                {
                    Console.WriteLine($"{orders}");
                }
            }
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}