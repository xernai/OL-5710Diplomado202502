using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    // TDD: Test Driven Development
    public class Calculator
    {
        public int Sum(int x, int y)
        {
            // TODO
            var result = x + y;
            return result;
        }

        public int Rest(int x, int y)
        {
            // TODO
            var result = x - y;
            return result;
        }

        public int Multiply(int x, int y)
        {
            // TODO
            var result = x * y;
            return result;
        }

        public int Divide(int x, int y)
        {
            // TODO
            if (y == 0)
                return 0;

            var result = x / y;
            return result;
        }
    }
}
