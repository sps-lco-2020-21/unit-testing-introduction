using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeService.Lib
{
    public class PrimeChecker
    {
        public bool IsPrime(int number)
        {
            if (number == 1 || number == 2)
                return true;
            return false;
        }
    }
}
