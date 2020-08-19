using System;
using System.Windows.Forms;
namespace ObjectOrientedCalculator.Operations
{
    public class Sqrt : IOneArgCalculator
    {
        public double Calculate(double a)
        {
            return (Math.Sqrt(a));
        }
    }
}