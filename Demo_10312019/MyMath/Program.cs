using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    class Program
    {
        static void Main(string[] args)
        {
            // using add method in main:
            Console.WriteLine("101 + 99 = {0}", MyMath1.Add((byte)101,(byte)99));
            // this answer is wrong when run bc of data type limitations?
            Console.WriteLine("101 + 201 = {0}", MyMath1.Add((byte)101, (byte)201));

            // overflow example skipped
        }
    }
}
