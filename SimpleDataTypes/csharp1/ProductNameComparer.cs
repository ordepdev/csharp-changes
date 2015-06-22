using System.Collections;

namespace SimpleDataTypes.csharp1
{
    /// summary
    ///     The comparison always tries to cast an object to a Product
    ///     If an object is not a Product the program crashes
    class ProductNameComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Product first = (Product)x;
            Product second = (Product)y;
            return first.Name.CompareTo(second.Name);
        }
    }
}
