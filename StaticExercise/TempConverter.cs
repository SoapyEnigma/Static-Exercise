using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    static public class TempConverter
    {
        static public double FahrenheitToCelsius(double f)
        {
            return (f - 32) / 1.8;
        }

        static public double CelsiusToFahrenheit(double c)
        {
            return (c * 1.8) + 32;
        }
    }
}
