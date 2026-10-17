using LINQ.DataSources;
using LINQ.Models;
using static LINQ.DataSources.Source;
namespace LINQ
{
    internal class Program
    {
        static void Main()
        {
            #region Question 1
            //1.Get all products from the "Seafood" category.Print each
            //product's name and price.

            //var result = Source.ProductList.Where(p => p.Category == "Seafood").Select(p => new { p.ProductName, p.UnitPrice });
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Product: {item.ProductName}, Price: {item.UnitPrice}");
            //}
            #endregion

            #region Question 2
            //2.Get a list of only the product names from ProductList.Print
            //each name.

            var result = Source.ProductList.Select(p => p.ProductName);
            foreach (var item in result)
            {
                Console.WriteLine($"Product: {item}");
            }
            #endregion
        }
    }
}
