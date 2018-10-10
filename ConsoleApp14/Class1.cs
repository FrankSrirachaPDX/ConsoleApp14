using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Class1
    {

        public static int Math1(int x)
        {
            x = x + 20;

            return x;
        }

        public static int Math2(double y)
        {
            int num;
            y = y / 2;
            num = Convert.ToInt32(y);

            return num;
        }

        public static int Math3(string z)
        {
            int num;
            num = Convert.ToInt32(z);
            num = num + 2;
            return num;
        }



    }
}
