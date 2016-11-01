
using System.Collections.Generic;
using System.Reflection;

namespace ConsoleApplication
{
    static class extensions
    {
        // From http://stackoverflow.com/a/4951271
        public static List<Variance> DetailedCompare<T>(this T val1, T val2)
        {
            List<Variance> variances = new List<Variance>();
            PropertyInfo[] properties = val1.GetType().GetProperties();
            foreach (var property in properties)
            {
                var v = new Variance();
                v.Prop = property.Name;
                v.valA = property.GetValue(val1);
                v.valB = property.GetValue(val2);
                if (!object.Equals(v.valA, v.valB))
                {
                    variances.Add(v);
                }
            }
            return variances;
        }
    }
    class Variance
    {
        public string Prop { get; set; }
        public object valA { get; set; }
        public object valB { get; set; }
    }
}