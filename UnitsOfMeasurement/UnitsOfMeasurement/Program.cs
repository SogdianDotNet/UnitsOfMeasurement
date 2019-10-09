using Microsoft.Extensions.DependencyInjection;
using System;
using UnitsOfMeasurement.Calculators;
using UnitsOfMeasurement.Models;
using UnitsOfMeasurement.Models.MassScales;
using UnitsOfMeasurement.Models.TemperatureScales;
using UnitsOfMeasurement.Shared;

namespace UnitsOfMeasurement
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            do
            {
                try
                {
                    Console.WriteLine("Type 1 to start the measurements or any other key to stop.");
                    input = Console.ReadLine();

                    if (input != "1")
                        break;

                    Console.WriteLine("Welcome to the units of measurement converter");
                    Console.WriteLine("What units of measurement do you want to convert?");
                    Console.WriteLine("Choose 1 for temperatures, 2 for mass");
                    var unitOfMeasurement = Convert.ToInt32(Console.ReadLine());

                    switch (unitOfMeasurement)
                    {
                        case 1:
                            TemperatureConverter();
                            break;
                        case 2:
                            MassConverter();
                            break;
                    }
                }
                catch (Exception)
                {
                    continue;
                }
            }
            while (true);
        }

        private static void MassConverter()
        {
            ICalculator calculator = new MassCalculator();

            Console.WriteLine("What mass unit do you want to convert from?");
            Console.WriteLine("Options: 1 for Milligrams, 2 for Grams, 3 for Kilograms, 4 for Ounces, 5 for Pounds, 6 for Stones");
            var convertFrom = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What mass unit do you want to convert to?");
            Console.WriteLine("Options: 1 for Milligrams, 2 for Grams, 3 for Kilograms, 4 for Ounces, 5 for Pounds, 6 for Stones");
            var convertTo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the value you want to convert?");
            var valueToConvert = Convert.ToDouble(Console.ReadLine());

            IUnit from = null;
            IUnit to = null;

            switch (convertFrom)
            {
                case 1:
                    from = new Milligram { Value = valueToConvert };
                    break;
                case 2:
                    from = new Gram { Value = valueToConvert };
                    break;
                case 3:
                    from = new Kilogram { Value = valueToConvert };
                    break;
                case 4:
                    from = new Ounce { Value = valueToConvert };
                    break;
                case 5:
                    from = new Pound { Value = valueToConvert };
                    break;
                case 6:
                    from = new Stone { Value = valueToConvert };
                    break;
            }

            switch (convertTo)
            {
                case 1:
                    to = new Milligram { Value = valueToConvert };
                    break;
                case 2:
                    to = new Gram { Value = valueToConvert };
                    break;
                case 3:
                    to = new Kilogram { Value = valueToConvert };
                    break;
                case 4:
                    to = new Ounce { Value = valueToConvert };
                    break;
                case 5:
                    to = new Pound { Value = valueToConvert };
                    break;
                case 6:
                    to = new Stone { Value = valueToConvert };
                    break;
            }

            var result = calculator.Calculate(from, to);
            Console.WriteLine($"Well, {from.Value} {from.Name.ToLower()}(s) is equal to {result} {to.Name.ToLower()}(s).");
        }

        private static void TemperatureConverter()
        {
            ICalculator calculator = new TemperatureCalculator();

            Console.WriteLine("What temperature unit do you want to convert from?");
            Console.WriteLine("Options: 1 for Celsius, 2 for Fahrenheit and 3 for Kelvin");
            var convertFrom = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What temperature unit do you want to convert to?");
            Console.WriteLine("Options: 1 for Celsius, 2 for Fahrenheit and 3 for Kelvin");
            var convertTo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the value you want to convert?");
            var valueToConvert = Convert.ToDouble(Console.ReadLine());

            IUnit from = null;
            IUnit to = null;

            switch (convertFrom)
            {
                case 1:
                    from = new Celsius { Value = valueToConvert };
                    break;
                case 2:
                    from = new Fahrenheit { Value = valueToConvert };
                    break;
                case 3:
                    from = new Kelvin { Value = valueToConvert };
                    break;
            }

            switch (convertTo)
            {
                case 1:
                    to = new Celsius();
                    break;
                case 2:
                    to = new Fahrenheit();
                    break;
                case 3:
                    to = new Kelvin();
                    break;
            }

            var result = calculator.Calculate(from, to);
            Console.WriteLine($"Well, {from.Value} degrees Celsius is equal to {result} degrees {to.Name}.");
        }
    }
}
