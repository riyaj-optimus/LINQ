
using System;
using System.Collections.Generic;


namespace Linq_Assignment
{
    class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public double OrderAmount { get; set; }
        public DateTime OrderDate { get; set; }
    }

    class two
    {
        //static void Main()
        //{

        //    List<Order> orders = new List<Order>
        //{
        //    new Order { OrderID = 1, CustomerID = 101, OrderAmount = 250.50, OrderDate = new DateTime(2024, 11, 1) },
        //    new Order { OrderID = 2, CustomerID = 102, OrderAmount = 150.00, OrderDate = new DateTime(2024, 11, 2) },
        //    new Order { OrderID = 3, CustomerID = 101, OrderAmount = 300.75, OrderDate = new DateTime(2024, 11, 5) },
        //    new Order { OrderID = 4, CustomerID = 103, OrderAmount = 450.00, OrderDate = new DateTime(2024, 11, 10) },
        //    new Order { OrderID = 5, CustomerID = 102, OrderAmount = 200.00, OrderDate = new DateTime(2024, 11, 15) },
        //    new Order { OrderID = 6, CustomerID = 104, OrderAmount = 500.25, OrderDate = new DateTime(2024, 11, 20) }
        //};


        //    var res = orders.GroupBy(c => c.CustomerID).Select(grp => new
        //    {
        //        key = grp.Key,
        //        totalAmountForId = grp.Sum(i => i.OrderAmount)
        //    });

        //    foreach (var i in res)
        //    {
        //        Console.WriteLine($"CustomerID: {i.key}, totalAmountForId: {i.totalAmountForId}");
        //    }
        //}
    }


}


