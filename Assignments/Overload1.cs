using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignments
{
    public class Overload1
    {
        public int Function1(int x)
        {
            x++;
            return x;
        }
        public float Function1(float x)
        {
            x += 7;
            return Convert.ToInt32(x);
        }
        public int Function1(string str)
        {
            int num = Convert.ToInt32(str);
            num++;
            return num;
        }
    }
}
