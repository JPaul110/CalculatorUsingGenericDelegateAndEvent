using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    public delegate T Formula<T>(T arg1);
    internal class CalculatorClass
    {
        public Formula<double> frmula;


        public double GetSum(double a, double b)
        {
            return a + b;
        }

        public double GetDifference(double a, double b)
        {
            return a - b;
        }

        public event Formula<double> CalculateEvent
        {
            add
            {
                Console.WriteLine("Added the Delegate");
                frmula += value;
            }
            remove
            {
                Console.WriteLine("Delegate removed");
                frmula -= value;
            }
        }

        public double GetProduct(double Prduct1, double Prduct2)
        {
            return Prduct1 * Prduct2;
        }

        public double GetQuitient(double Quotient1, double Quotient2)
        {
            return Quotient1 / Quotient2;
        }
    }
}
