using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class AscComparer : ICustomComparer
    {
        public bool Compare(int x, int y) => x > y;
    }
}
