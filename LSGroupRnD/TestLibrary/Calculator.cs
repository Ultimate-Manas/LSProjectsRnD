using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    public class Calculator
    {
        public double Add(params double[] nums)
        {
            return nums.Sum();
        }
    }
}
