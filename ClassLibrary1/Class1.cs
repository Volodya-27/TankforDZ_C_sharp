using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class MyR
    {
        public static string GetRandom(ref Random random)
        {
            return random.Next(0, 100).ToString();
        }
    }
}
