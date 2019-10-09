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
                    Console.WriteLine("Choose 1 for temperatures, 2 for mass. Type 'exit' to stop the program.");
                    var unitOfMeasurement = Console.ReadLine();

                    if (unitOfMeasurement.ToLower() == "exit")
                        break;

                    while (!int.TryParse(unitOfMeasurement, out int number) || (Convert.ToInt32(unitOfMeasurement) < 0 || Convert.ToInt32(unitOfMeasurement) > 2))
                    {
                        Console.WriteLine("Error write only numbers and it must be between 1 and 2");
                        unitOfMeasurement = Console.ReadLine();

                        if (unitOfMeasurement.ToLower() == "exit")
                            break;
                    }

                    switch (unitOfMeasurement)
                    {
                        case "1":
                            TemperatureConverter();
                            break;
                        case "2":
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
            Console.WriteLine("Type 'exit' to stop the program.");
            var convertFrom = Console.ReadLine();

            while (!int.TryParse(convertFrom, out int number) || (Convert.ToInt32(convertFrom) < 1 || Convert.ToInt32(convertFrom) > 6))
            {
                Console.WriteLine("Error write only numbers and it must be between 1 and 6");
                Console.WriteLine("Type 'exit' to stop the program.");
                convertFrom = Console.ReadLine();

                if (convertFrom.ToLower() == "exit")
                    break;
            }

            Console.WriteLine("What mass unit do you want to convert to?");
            Console.WriteLine("Options: 1 for Milligrams, 2 for Grams, 3 for Kilograms, 4 for Ounces, 5 for Pounds, 6 for Stones");
            Console.WriteLine("Type 'exit' to stop the program.");
            var convertTo = Console.ReadLine();

            while (!int.TryParse(convertTo, out int number) || (Convert.ToInt32(convertTo) < 1 || Convert.ToInt32(convertTo) > 6))
            {
                Console.WriteLine("Error write only numbers and it must be between 1 and 6");
                Console.WriteLine("Type 'exit' to stop the program.");
                convertTo = Console.ReadLine();

                if (convertTo.ToLower() == "exit")
                    break;
            }

            Console.WriteLine("What is the value you want to convert?");
            var valueToConvert = Console.ReadLine();

            while (!double.TryParse(valueToConvert, out double number))
            {
                Console.WriteLine("Error write only numbers.");
                Console.WriteLine("Type 'exit' to stop the program.");
                valueToConvert = Console.ReadLine();

                if (valueToConvert.ToLower() == "exit")
                    break;
            }

            IUnit from = null;
            IUnit to = null;

            double valueInDoubleToConvert = double.Parse(valueToConvert);

            switch (convertFrom)
            {
                case "1":
                    from = new Milligram { Value = valueInDoubleToConvert };
                    break;
                case "2":
                    from = new Gram { Value = valueInDoubleToConvert };
                    break;
                case "3":
                    from = new Kilogram { Value = valueInDoubleToConvert };
                    break;
                case "4":
                    from = new Ounce { Value = valueInDoubleToConvert };
                    break;
                case "5":
                    from = new Pound { Value = valueInDoubleToConvert };
                    break;
                case "6":
                    from = new Stone { Value = valueInDoubleToConvert };
                    break;
            }

            switch (convertTo)
            {
                case "1":
                    to = new Milligram();
                    break;
                case "2":
                    to = new Gram();
                    break;
                case "3":
                    to = new Kilogram();
                    break;
                case "4":
                    to = new Ounce();
                    break;
                case "5":
                    to = new Pound();
                    break;
                case "6":
                    to = new Stone();
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
            Console.WriteLine("Type 'exit' to stop the program.");
            var convertFrom = Console.ReadLine();

            while (!int.TryParse(convertFrom, out int number) || (Convert.ToInt32(convertFrom) < 1 || Convert.ToInt32(convertFrom) > 3))
            {
                Console.WriteLine("Error write only numbers and it must be between 1 and 3");
                Console.WriteLine("Type 'exit' to stop the program.");
                convertFrom = Console.ReadLine();

                if (convertFrom.ToLower() == "exit")
                    break;
            }

            Console.WriteLine("What temperature unit do you want to convert to?");
            Console.WriteLine("Options: 1 for Celsius, 2 for Fahrenheit and 3 for Kelvin");
            Console.WriteLine("Type 'exit' to stop the program.");
            var convertTo = Console.ReadLine();

            while (!int.TryParse(convertTo, out int number) || (Convert.ToInt32(convertTo) < 1 || Convert.ToInt32(convertTo) > 3))
            {
                Console.WriteLine("Error write only numbers and it must be between 1 and 3");
                Console.WriteLine("Type 'exit' to stop the program.");
                convertTo = Console.ReadLine();

                if (convertTo.ToLower() == "exit")
                    break;
            }

            Console.WriteLine("What is the value you want to convert?");
            Console.WriteLine("Type 'exit' to stop the program.");
            var valueToConvert = Console.ReadLine();

            while (!double.TryParse(valueToConvert, out double number))
            {
                Console.WriteLine("Error write only numbers.");
                Console.WriteLine("Type 'exit' to stop the program.");
                valueToConvert = Console.ReadLine();

                if (valueToConvert.ToLower() == "exit")
                    break;
            }

            IUnit from = null;
            IUnit to = null;

            double valueInDoubleToConvert = double.Parse(valueToConvert);

            switch (convertFrom)
            {
                case "1":
                    from = new Celsius { Value = valueInDoubleToConvert };
                    break;
                case "2":
                    from = new Fahrenheit { Value = valueInDoubleToConvert };
                    break;
                case "3":
                    from = new Kelvin { Value = valueInDoubleToConvert };
                    break;
            }

            switch (convertTo)
            {
                case "1":
                    to = new Celsius();
                    break;
                case "2":
                    to = new Fahrenheit();
                    break;
                case "3":
                    to = new Kelvin();
                    break;
            }

            var result = calculator.Calculate(from, to);
            Console.WriteLine($"Well, {from.Value} degrees Celsius is equal to {result} degrees {to.Name}.");
        }
    }
}
