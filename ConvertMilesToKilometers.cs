using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertMilesToKilometers
{
    class ConvertMilesToKilometers
    {
        static void Main(string[] args)
        {
            double miles;
            Console.Write("Enter Miles >> ");
            miles = Convert.ToDouble(Console.ReadLine());

            double convertedvalue = ConvertToKilometers(miles);
            Console.WriteLine("{0} miles is {1} kilometers", miles, convertedvalue);

        }

        public static double ConvertToKilometers(double miles)
        {
            const double CONVERSION = 1.60934;
            double kilometers = miles * CONVERSION;

            return kilometers;

        }
    }
}
