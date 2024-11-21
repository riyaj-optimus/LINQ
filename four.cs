using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Assignment
{

    using System;
    using System.Collections.Generic;

    class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
    }

    class Orders
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public double OrderAmount { get; set; }
    }

    class Program
    {
        //static void Main()
        //{
            
        //    List<Customer> customers = new List<Customer>
        //{
        //    new Customer { CustomerID = 1, CustomerName = "Alice", Email = "alice@example.com" },
        //    new Customer { CustomerID = 2, CustomerName = "Bob", Email = "bob@example.com" },
        //    new Customer { CustomerID = 3, CustomerName = "Charlie", Email = "charlie@example.com" },
        //    new Customer { CustomerID = 4, CustomerName = "David", Email = "david@example.com" }
        //};

            
        //    List<Orders> orders = new List<Orders>
        //{
        //    new Orders { OrderID = 101, CustomerID = 1, OrderAmount = 250.00 },
        //    new Orders { OrderID = 102, CustomerID = 2, OrderAmount = 150.50 },
        //    new Orders { OrderID = 103, CustomerID = 3, OrderAmount = 300.75 },
        //    new Orders { OrderID = 104, CustomerID = 1, OrderAmount = 450.25 },
        //    new Orders { OrderID = 105, CustomerID = 4, OrderAmount = 500.00 }
        //};

        //   var res = orders.Join(customers,o=>o.CustomerID, c=>c.CustomerID, (o, c)=> new
        //   {
        //       o.OrderID, c.CustomerName, o.OrderAmount
        //   });

        //    foreach(var i  in res)
        //    {
        //        Console.WriteLine($"Order ID : {i.OrderID} OrderAmount : {i.OrderAmount}            CustomerName : {i.CustomerName}  ");
        //    }
        //}
    }


}
