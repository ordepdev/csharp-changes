using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleDataTypes.csharp3
{
    /// summary
    ///     The properties don't have any code associated with them
    ///     The hardcoded list is builded in a very different way
    ///         with no name and price variables to access, we're forced
    ///         to use the properties everywhere in the class, improving consistency
    ///     New property-based initialization
    public class Product
    {
        public string Name { get; private set; }

        public decimal Price { get; private set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        Product() { }

        public static List<Product> GetSampleProducts()
        {
            return new List<Product>()
            {
                new Product("foo", 1.00m),
                new Product("bar", 1.99m)
            };
        }

        public List<Product> SortProductsWithDelegate()
        {
            List<Product> products = Product.GetSampleProducts();

            // lambda expression, which still creates a Comparison<Product> delegate
            products.Sort((x, y) => x.Name.CompareTo(y.Name));

            return products;
        }

        public List<Product> SortProductsWithLinq()
        {
            List<Product> products = Product.GetSampleProducts();

            // with .OrderBy we keep the products list unsorted
            return products.OrderBy(x => x.Name).ToList();
        }

        // testing with lambda expression
        public void QueryProducts()
        {
            List<Product> products = Product.GetSampleProducts();

            foreach (Product product in products.Where(p => p.Price > 1m))
            {
                Console.WriteLine(product);
            }
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", Name, Price);
        }
    }
}
