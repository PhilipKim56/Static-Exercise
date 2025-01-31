﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public class TempConverter
    {
        public static double FahrenheitToCelsius (double fahrenheit)
        {
            return (fahrenheit - 32) / 1.8;
        }

        public static double CelsiusToFarenheit (double celsius)
        {
            return (celsius * 9) / 5 + 32;
        }
    }
}
