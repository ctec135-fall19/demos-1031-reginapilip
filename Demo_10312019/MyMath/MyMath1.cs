using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    public class MyMath1
    {
        // static essentially means I can call a method without creating
        // an object
        public static byte Add(byte x, byte y)
        {
            // keyword: checked. Alt. way to just having the
            // commented return statement
            // a form of exception handling
            checked
            {
                byte b = (byte)(x + y);
                return b;
            }
            // return (byte)(x + y); 
        }
    }
}
