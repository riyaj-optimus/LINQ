using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Assignment
{ 

    public class Sale
    {
        public int ProductID { get; set; }
        public DateTime SaleDate { get; set; }
        public int QuantitySold { get; set; }
    }

    class five
    {
        //static void Main()
        //{
            
        //    var sales = new List<Sale>
        //{
        //    new Sale { ProductID = 1, SaleDate = DateTime.Now.AddDays(-10), QuantitySold = 50 },
        //    new Sale { ProductID = 2, SaleDate = DateTime.Now.AddDays(-15), QuantitySold = 30 },
        //    new Sale { ProductID = 1, SaleDate = DateTime.Now.AddDays(-5), QuantitySold = 70 },
        //    new Sale { ProductID = 3, SaleDate = DateTime.Now.AddDays(-20), QuantitySold = 40 },
        //    new Sale { ProductID = 2, SaleDate = DateTime.Now.AddDays(-25), QuantitySold = 60 },
        //    new Sale { ProductID = 3, SaleDate = DateTime.Now.AddDays(-2), QuantitySold = 90 }
        //};

        //    var res = sales.Where(s => s.SaleDate >= DateTime.Now.AddDays(-30)).GroupBy(g=> g.ProductID).Select(qnt => new
        //    {
        //        ID = qnt.Key,
        //        TotalQuantitySold = qnt.Sum(s => s.QuantitySold)
        //    });

        //    foreach(var i in res)
        //    {
        //        Console.WriteLine($" ID : {i.ID} TotalQuantitySold : {i.TotalQuantitySold} ");
        //    }
        //}
    }

}
