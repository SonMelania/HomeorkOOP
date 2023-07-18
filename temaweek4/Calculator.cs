using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temaweek4
{
    public class Calculator
    {
        public Calculator( )
        {

        }


        public int Add  (int x, int y)
        { 
            return x + y;
        }
        public int Subtract (int x, int y)
        {
            return x - y;
        }
        public int Multiply (int x, int y)
        {
            return x * y;
        }
        public int Divide (int x, int y)
        {
            return x / y;
        }
        public double  Power(double x, double y)
        { return Math.Pow(x,y); }

        public double Square (double x)
        {
            return Math.Sqrt(x);   
        }
        
    }
}
