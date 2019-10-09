using System;
using System.Collections.Generic;
using System.Text;
using UnitsOfMeasurement.Models;
using UnitsOfMeasurement.Models.MassScales;
using UnitsOfMeasurement.Models.TemperatureScales;

namespace UnitsOfMeasurement.Calculators
{
    public interface ICalculator
    {
        double Calculate(IUnit from, IUnit to);
    }
}
