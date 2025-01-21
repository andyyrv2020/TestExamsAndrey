using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Three
{
    public class Doggo
    {
        private static int count;
        public Doggo()
        {
            count++;
        }

        public static int Count { get => count; }
    }
}
