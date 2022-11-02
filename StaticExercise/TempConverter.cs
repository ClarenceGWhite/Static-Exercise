using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {

        public static double FahrenheitToCelsius(double fahrenheitTemp)
        {
            // C = (F - 32) * 5 / 9;
            return (fahrenheitTemp - 32) * 5 / 9;
               
        }

        public static double CelsiusToFahrenheit(double celsiusTemp) 
        {
            // F = (C * 9)/5 + 32
            return (celsiusTemp * 9) / 5 + 32;
                
        }





    }
}
