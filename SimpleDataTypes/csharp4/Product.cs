using System.Collections.Generic;

namespace SimpleDataTypes.csharp4
{
    /// summary
    ///    Properties and constructor are fully immutable
    ///    Methods and constructors have named arguments
    public class Product
    {
        readonly string name;
        public string Name { get { return name; } }

        readonly decimal price;
        public decimal Price { get { return price; } }

        public Product(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public static List<Product> GetSampleProducts()
        {
            return new List<Product>()
            {
                new Product(name: "foo", price: 1.00m),
                new Product(name: "bar", price: 1.99m)
            };
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", Name, Price);
        }
    }
}
