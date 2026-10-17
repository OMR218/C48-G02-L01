using LINQ.DataSources;
using LINQ.Models;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Xml.Linq;
using static LINQ.DataSources.Source;
namespace LINQ
{
    internal class Program
    {
        static void Main()
        {
            #region First Assignment
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

            //var result = Source.ProductList.Select(p => new
            //{
            //    Name = p.ProductName,
            //    Price = p.UnitPrice,
            //    StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Product: {item.Name}, Price: {item.Price}, Stock Status: {item.StockStatus}");
            //}
            #endregion

            #region Question 7
            //7.Print each product's name along with its position (1-based) 
            //in the list. Expected format: 1.Chai, 2.Chang, etc.

            //var result = Source.ProductList.Select((p, index) => new { Position = index + 1, ProductName = p.ProductName });
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Position}. {item.ProductName}");
            //}
            #endregion

            #region Question 8
            //8.Sort ProductList by Category ascending, then within each
            //category, sort by UnitPrice descending. 

            //var result = Source.ProductList
            //    .OrderBy(p => p.Category)
            //    .ThenByDescending(p => p.UnitPrice);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Product: {item.ProductName}, Price: {item.UnitPrice}");
            //}
            #endregion

            #region Question 9
            //9.Get all products from the "Beverages" category, sorted by
            //UnitsInStock descending. Print name and stock.

            //var result = Source.ProductList.Where(P => P.Category == "Beverages").OrderByDescending(P => P.UnitsInStock);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Product: {item.ProductName}, Stock: {item.UnitsInStock}");
            //}
            #endregion

            #region Question 10
            //10.Using QUERY SYNTAX with a compound from clause, list
            //all orders placed in 1997 or later showing CustomerID and
            //OrderDate.

            //var result = from C in Source.CustomerList
            //             from O in C.Orders
            //             where O.OrderDate.Year >= 1997
            //             select new { C.CustomerID, O.OrderDate };

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"CustomerID: {item.CustomerID}, OrderDate: {item.OrderDate:yyyy-MM-dd}");
            //}
            #endregion

            #region Question 11
            //11.Show posiation number alongside ProductName

            //var result = Source.ProductList.Select((p, index) => new { Position = index + 1, ProductName = p.ProductName });
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Position}. {item.ProductName}");
            //}
            #endregion

            #region Question 12
            //12.Sort first by-word length and then by a
            //case -insensitive sort of the words in an array. 
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr
            //    .OrderBy(word => word.Length)
            //    .ThenBy(word => word, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in result)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion

            #region Question 13
            //13.Create a list of all digits in the array whose second
            //letter is 'i' that is reversed from the order in the
            //original array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr
            //    .Where(word => word.Length > 1 && char.ToLower(word[1]) == 'i')
            //    .Reverse()
            //    .ToList();

            //foreach (var word in result)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion
            #endregion

            #region Second Assignment 
            #region Question 1
            // 1. Get the top 3 most expensive products. Print each product's name and price.

            //var result = Source.ProductList.OrderByDescending(p => p.UnitPrice).Take(3);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Product: {item.ProductName}, Price: {item.UnitPrice}");
            //}
            #endregion

            #region Question 2
            // 2. Show page 2 of products, with a page size of 5.

            //var result = Source.ProductList.Skip(5).Take(5);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Product: {item.ProductName}, ID: {item.ProductID}");
            //}
            #endregion

            #region Question 3
            // 3. Take products as long as their UnitPrice is less than $25.

            //var result = Source.ProductList.OrderBy(p => p.UnitPrice).TakeWhile(p => p.UnitPrice < 25);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Product: {item.ProductName}, Price: {item.UnitPrice}");
            //}
            #endregion

            #region Question 4
            // 4. Check if all products in the "Seafood" category are in stock.

            //var result = Source.ProductList.Where(p => p.Category == "Seafood").All(p => p.UnitsInStock > 0);
            //Console.WriteLine(result);
            #endregion

            #region Question 5
            // 5. Check if the ID list contains 9.

            //int[] ids = { 3, 9, 13, 18 };
            //var result = ids.Contains(9);
            //Console.WriteLine(result);
            #endregion

            #region Question 6
            // 6. Group all products by Category and print each group with its product count.

            //var result = Source.ProductList.GroupBy(p => p.Category);
            //foreach (var group in result)
            //{
            // Console.WriteLine($"{group.Key}: {group.Count()} products");
            //}
            #endregion

            #region Question 7
            // 7. Group products by Category and select only product names for each group.

            //var result = Source.ProductList.GroupBy(p => p.Category, p => p.ProductName);
            //foreach (var group in result)
            //{
            //    Console.WriteLine(group.Key);
            //    foreach (var name in group)
            //    {
            //        Console.WriteLine(name);
            //    }
            //}
            #endregion

            #region Question 8
            // 8. Find all categories that have more than 3 products.

            //var result = Source.ProductList.GroupBy(p => p.Category).Where(g => g.Count() > 3).Select(g => g.Key);
            //foreach (var category in result)
            //{
            // Console.WriteLine(category);
            //}
            #endregion

            #region Question 9
            // 9. Using query syntax, group customers by Country and select Country, Count, and TotalOrderValue.

            //var result = from c in Source.CustomerList
            // group c by c.Country into countryGroup
            // select new
            // {
            // Country = countryGroup.Key,
            // Count = countryGroup.Count(),
            // TotalOrderValue = countryGroup.Sum(c => c.Orders.Sum(o => o.Total))
            // };
            //foreach (var item in result)
            //{
            // Console.WriteLine($"Country: {item.Country}, Count: {item.Count}, TotalOrderValue: {item.TotalOrderValue}");
            //}
            #endregion

            #region Question 10
            // 10. Calculate the total number of units in stock across all products.

            //var result = Source.ProductList.Sum(p => p.UnitsInStock);
            //Console.WriteLine(result);
            #endregion

            #region Question 11
            // 11. Find the cheapest and most expensive product prices.

            //var cheapest = Source.ProductList.Min(p => p.UnitPrice);
            //var mostExpensive = Source.ProductList.Max(p => p.UnitPrice);
            //Console.WriteLine($"Cheapest Price: {cheapest}");
            //Console.WriteLine($"Most Expensive Price: {mostExpensive}");
            #endregion

            #region Question 12
            // 12. Get a distinct list of all product categories.

            //var result = Source.ProductList.Select(p => p.Category).Distinct();
            //foreach (var category in result)
            //{
            // Console.WriteLine(category);
            //}
            #endregion

            #endregion
        }
    }
}