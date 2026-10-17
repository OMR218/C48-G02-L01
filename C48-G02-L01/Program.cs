using LINQ.DataSources;
using LINQ.Models;
using System.Drawing;
using System.Xml.Linq;
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

            //var result = Source.ProductList.Select(p => p.ProductName);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Product: {item}");
            //}
            #endregion

            #region Question 3
            //3.Sort all products by UnitPrice(ascending). Print each
            //product's name and price.

            //var SortedProducts = Source.ProductList.OrderBy(p => p.UnitPrice);
            //foreach (var item in SortedProducts)
            //{
            //    Console.WriteLine($"Product: {item.ProductName}, Price: {item.UnitPrice}");
            //}
            #endregion

            #region Question 4
            //4.Get all products where UnitPrice is between 10 and 30

            //var result = Source.ProductList.Where(P => P.UnitPrice >= 10 && P.UnitPrice <= 30);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Product: {item.ProductName}, Price: {item.UnitPrice}");
            //}
            #endregion

            #region Question 5
            //5. Get all products that are in stock (UnitsInStock > 0) and 
            //belong to the "Condiments" category.

            //var result = Source.ProductList.Where(P => P.UnitsInStock > 0 && P.Category == "Condiments");

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Product: {item.ProductName}, Price: {item.UnitPrice}, UnitsInStock: {item.UnitsInStock}");
            //}
            #endregion

            #region Question 6
            //6.Create a new anonymous type with three properties: 
            //● Name → the product name
            //● Price → the unit price
            //● StockStatus → a string: "Available" if UnitsInStock > 0, 
            //otherwise "Out of Stock"
            //● Print the result.

            var result = Source.ProductList.Select(p => new
            {
                Name = p.ProductName,
                Price = p.UnitPrice,
                StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
            });

            foreach (var item in result)
            {
                Console.WriteLine($"Product: {item.Name}, Price: {item.Price}, Stock Status: {item.StockStatus}");
            }
            #endregion
        }
    }
}
