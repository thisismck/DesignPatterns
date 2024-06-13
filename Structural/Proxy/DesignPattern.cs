using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public interface IMath
    {
        double Division(double x, double y);        
    }

    public class Math : IMath
    {
        public double Division(double x, double y)
        {
            return x / y;
        }
    }

    public class MathProxy : IMath
    {
        private Math _math = new Math();

        public double Division(double x, double y)
        {
            if (y == 0)
            {
                Console.WriteLine("Division by zero is not allowed.");
                return double.NaN;
            }

            return _math.Division(x, y);
        }
    }

}
