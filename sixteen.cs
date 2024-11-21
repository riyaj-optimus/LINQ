using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Assignment
{
    

    public class Pro
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }

    class sixteen
    {
        //public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { HashSet<TKey> seenKeys = new HashSet<TKey>(); foreach (TSource element in source) { if (seenKeys.Add(keySelector(element))) { yield return element; } } }
        //var myDistinctList = myList.DistinctBy(x => x.Medium);
        static void Main()
        {
            
            var ProductsA = new List<Pro>
        {
            new Pro { ProductID = 1, ProductName = "Laptop", Price = 1200.50m },
            new Pro { ProductID = 2, ProductName = "Smartphone", Price = 800.00m },
            new Pro { ProductID = 3, ProductName = "Tablet", Price = 300.00m }
        };

            
            var ProductsB = new List<Pro>
        {
            new Pro { ProductID = 2, ProductName = "Smartphone", Price = 800.00m },
            new Pro { ProductID = 4, ProductName = "Monitor", Price = 250.00m },
            new Pro { ProductID = 5, ProductName = "Mouse", Price = 25.50m }
        };

            var res = ProductsA.Union(ProductsB);

            ProductsA.Concat(ProductsB);


            foreach (var i in ProductsB)
            {
                Console.WriteLine(i.ProductID);
            }

            
        }
    }

}
