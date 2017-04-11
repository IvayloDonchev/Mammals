using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegInt32
{
    public static class Util
    {
        public static int Negate(this int x)
        {
            return -x;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            Console.WriteLine(i.Negate());
            Console.WriteLine(Util.Negate(i));
        }
    }
}
