using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FarenheitToCelsius(double farenheit)
        {
            var answer = (farenheit - 32) / 1.8;
            return answer;
        }
        public static double CelsiusToFarenheit(double celsius)
        {
            return ((celsius * 9) / 5) + 32;
        }
    }
}
