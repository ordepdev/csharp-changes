using System.Collections.Generic;

namespace SimpleDataTypes.csharp2
{
    /// summary
    ///     No casting is necessary because we are giving products
    class ProductNameComparer : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
