using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class ComparisonTypes
    {
        public static bool CompareLess(int x, int y) => x < y;

        public static bool CompareGreater(int x, int y) => x > y;

        public static bool CompareGreater(double x, int y) => x > y;

        public static bool CompareGreater(string x, string y) => x.CompareTo(y)>0;
    }
}
