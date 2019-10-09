using System;
using System.Collections.Generic;
using System.Text;

namespace UnitsOfMeasurement.Models
{
    public interface IUnit
    {
        double Value { get; set; }
        string Name { get; }
    }
}
