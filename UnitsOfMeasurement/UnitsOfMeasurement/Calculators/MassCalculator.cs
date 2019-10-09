using System;
using System.Collections.Generic;
using System.Text;
using UnitsOfMeasurement.Models;
using UnitsOfMeasurement.Models.MassScales;

namespace UnitsOfMeasurement.Calculators
{
    public class MassCalculator : ICalculator
    {
        public double Calculate(IUnit from, IUnit to)
        {
            if (from.GetType().IsAssignableFrom(typeof(Kilogram)))
                return ConvertKilograms(from, to);

            if (from.GetType().IsAssignableFrom(typeof(Gram)))
                return ConvertGrams(from, to);

            if (from.GetType().IsAssignableFrom(typeof(Milligram)))
                return ConvertMilligrams(from, to);

            if (from.GetType().IsAssignableFrom(typeof(Ounce)))
                return ConvertOunces(from, to);

            throw new InvalidOperationException();
        }

        private double ConvertOunces(IUnit from, IUnit to)
        {
            if (to.GetType().IsAssignableFrom(typeof(Milligram)))
            {
                to.Value = MassFormulas.ConvertOuncesToKilograms(from.Value) * 1000000;
                return to.Value;
            }

            if (to.GetType().IsAssignableFrom(typeof(Gram)))
            {
                to.Value = MassFormulas.ConvertOuncesToKilograms(from.Value) * 1000;
                return to.Value;
            }

            if (to.GetType().IsAssignableFrom(typeof(Kilogram)))
            {
                to.Value = MassFormulas.ConvertOuncesToKilograms(from.Value);
                return to.Value;
            }

            if (to.GetType().IsAssignableFrom(typeof(Ounce)))
            {
                to.Value = from.Value;
                return to.Value;
            }

            if (to.GetType().IsAssignableFrom(typeof(Pound)))
            {
                to.Value = MassFormulas.ConvertOuncesToPounds(from.Value);
                return to.Value;
            }

            if (to.GetType().IsAssignableFrom(typeof(Stone)))
            {
                to.Value = MassFormulas.ConvertOuncesToStones(from.Value);
                return to.Value;
            }

            throw new InvalidOperationException();
        }

        private double ConvertMilligrams(IUnit from, IUnit to)
        {
            if (to.GetType().IsAssignableFrom(typeof(Milligram)))
            {
                to.Value = from.Value;
                return to.Value;
            }

            if (to.GetType().IsAssignableFrom(typeof(Gram)))
            {
                to.Value = from.Value / 1000;
                return to.Value;
            }

            if (to.GetType().IsAssignableFrom(typeof(Kilogram)))
            {
                to.Value = from.Value / 1000000;
                return to.Value;
            }

            if (to.GetType().IsAssignableFrom(typeof(Ounce)))
            {
                to.Value = MassFormulas.ConvertKilogramsToOunces(from.Value / 1000000);
                return to.Value;
            }

            if (to.GetType().IsAssignableFrom(typeof(Pound)))
            {
                to.Value = MassFormulas.ConvertKilogramsToPounds(from.Value / 1000000);
                return to.Value;
            }

            if (to.GetType().IsAssignableFrom(typeof(Stone)))
            {
                to.Value = MassFormulas.ConvertKilogramsToStones(from.Value / 1000000);
            }

            throw new InvalidOperationException();
        }

        private double ConvertGrams(IUnit from, IUnit to)
        {
            if (to.GetType().IsAssignableFrom(typeof(Kilogram)))
            {
                to.Value = from.Value / 1000;
                return to.Value;
            }

            if (to.GetType().IsAssignableFrom(typeof(Milligram)))
            {
                to.Value = from.Value * 1000;
                return to.Value;
            }

            if (to.GetType().IsAssignableFrom(typeof(Ounce)))
            {
                to.Value = MassFormulas.ConvertKilogramsToOunces(from.Value / 1000);
                return to.Value;
            }

            if (to.GetType().IsAssignableFrom(typeof(Pound)))
            {
                to.Value = MassFormulas.ConvertKilogramsToPounds(from.Value / 1000);
                return to.Value;
            }

            if (to.GetType().IsAssignableFrom(typeof(Stone)))
            {
                to.Value = MassFormulas.ConvertKilogramsToStones(from.Value / 1000);
                return to.Value;
            }

            if (to.GetType().IsAssignableFrom(typeof(Gram)))
            {
                to.Value = from.Value;
                return to.Value;
            }

            throw new InvalidOperationException();
        }

        private double ConvertKilograms(IUnit from, IUnit to)
        {
            if (to.GetType().IsAssignableFrom(typeof(Kilogram)))
            {
                to.Value = from.Value;
                return to.Value;
            }

            if (to.GetType().IsAssignableFrom(typeof(Pound)))
            {
                to.Value = MassFormulas.ConvertKilogramsToPounds(from.Value);
                return to.Value;
            }

            if (to.GetType().IsAssignableFrom(typeof(Ounce)))
            {
                to.Value = MassFormulas.ConvertKilogramsToOunces(from.Value);
                return to.Value;
            }

            if (to.GetType().IsAssignableFrom(typeof(Stone)))
            {
                to.Value = MassFormulas.ConvertKilogramsToStones(from.Value);
                return to.Value;
            }

            if (to.GetType().IsAssignableFrom(typeof(Milligram)))
            {
                to.Value = to.Value * 1000000;
                return to.Value;
            }

            if (to.GetType().IsAssignableFrom(typeof(Gram)))
            {
                to.Value = to.Value * 1000;
                return to.Value;
            }

            throw new InvalidOperationException();
        }
    }
}
