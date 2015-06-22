using System.Collections.Generic;

namespace SimpleDataTypes.csharp2
{
    /// summary
    ///     Private property setters
    ///     List<Product> is telling the compiler that the list
    ///         contains only products. Attempting to add a different type
    ///         to the list would result in a compiler error. No need to cast the results.
    ///     Introduction to delegates
    public class Product
    {
        string name;
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        decimal price;
        public decimal Price
        {
            get { return price; }
            private set { price = value; }
        }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public static List<Product> GetSampleProducts()
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("foo", 1.00m));
            list.Add(new Product("bar", 1.99m));
            return list;
        }

        public List<Product> SortProductsWithIComparer()
        {
            List<Product> products = Product.GetSampleProducts();
            products.Sort(new ProductNameComparer());
            return products;
        }

        public List<Product> SortProductsWithDelegate()
        {
            List<Product> products = Product.GetSampleProducts();

            products.Sort(delegate(Product x, Product y)
            {
                return x.Name.CompareTo(y.Name);
            });

            return products;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", name, price);
        }
    }
}
