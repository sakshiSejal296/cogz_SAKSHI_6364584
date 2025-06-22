using System;

namespace EcommerceSearch
{
    public class ProductSearch
    {
        // 🔍 Linear Search by Product Name
        public static Product LinearSearchByName(Product[] products, string targetName)
        {
            foreach (Product product in products)
            {
                if (product.ProductName.Equals(targetName, StringComparison.OrdinalIgnoreCase))
                {
                    return product;
                }
            }
            return null;
        }

        // 🔍 Binary Search by Product ID (requires sorted array)
        public static Product BinarySearchById(Product[] products, int targetId)
        {
            int low = 0;
            int high = products.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (products[mid].ProductId == targetId)
                    return products[mid];
                else if (products[mid].ProductId < targetId)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            return null;
        }
    }
}
