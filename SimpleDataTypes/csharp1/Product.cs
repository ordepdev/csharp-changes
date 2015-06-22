using System;
using System.Collections;

namespace SimpleDataTypes.csharp1
{
    public class Product
    {
        string name;
        // With public getter properties, if we want to implement setters
        // they will have to be public too
        public string Name { get { return name; } }

        decimal price;
        public decimal Price { get { return price; } }

        public Product(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        // An ArrayList has no compile-time information about what's in. 
        // You could accidentally add a string to the list. 
        public static ArrayList GetSampleProducts()
        {
            ArrayList list = new ArrayList();
            list.Add(new Product("foo", 1.00m));
            list.Add(new Product("bar", 1.99m));
            return list;
        }

        public ArrayList SortProducts()
        {
            ArrayList products = Product.GetSampleProducts();
            products.Sort(new ProductNameComparer());
            return products;
        }

        // Nested loop, testing and printing
        public void QueryProducts()
        {
            ArrayList products = Product.GetSampleProducts();
            foreach (Product product in products)
            {
                if (product.price > 1m)
                {
                    Console.WriteLine(product);
                }
            }
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", name, price);
        }
    }
}
