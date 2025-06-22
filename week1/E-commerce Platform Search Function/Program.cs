using System;
using System.Linq;

namespace EcommerceSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[]
            {
                new Product(103, "Laptop", "Electronics"),
                new Product(101, "Phone", "Electronics"),
                new Product(105, "Shoes", "Footwear"),
                new Product(102, "Watch", "Accessories"),
                new Product(104, "Tablet", "Electronics")
            };

            // 🔍 Linear Search by Name
            var linearResult = ProductSearch.LinearSearchByName(products, "watch");
            Console.WriteLine(linearResult != null ? $"Found (Linear): {linearResult.ProductName}" : "Not found");

            // ✅ Sort products by ProductId before Binary Search
            var sortedProducts = products.OrderBy(p => p.ProductId).ToArray();

            // 🔍 Binary Search by ID
            var binaryResult = ProductSearch.BinarySearchById(sortedProducts, 104);
            Console.WriteLine(binaryResult != null ? $"Found (Binary): {binaryResult.ProductName}" : "Not found");

            Console.ReadLine();
        }
    }
}
