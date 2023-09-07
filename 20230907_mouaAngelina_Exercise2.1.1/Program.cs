using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchesToCentimetersInteractive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double cent = 2.54;
            Console.WriteLine("How many inches do you want to convert to centimeters?");
            int inch = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(inch + " inches is " + cent * inch + " centimeters");
            Console.ReadLine();
        }
    }
}
