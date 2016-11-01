
using System.Collections.Generic;
using System.Reflection;

namespace ConsoleApplication
{
    static class extentions
    {
        // From http://stackoverflow.com/a/4951271
        public static List<Variance> DetailedCompare<T>(this T val1, T val2)
        {
            List<Variance> variances = new List<Variance>();
            PropertyInfo[] pi = val1.GetType().GetProperties();
            foreach (PropertyInfo p in pi)
            {
                Variance v = new Variance();
                v.Prop = p.Name;
                v.valA = p.GetValue(val1);
                v.valB = p.GetValue(val2);
                if (!v.valA.Equals(v.valB))
                    variances.Add(v);

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