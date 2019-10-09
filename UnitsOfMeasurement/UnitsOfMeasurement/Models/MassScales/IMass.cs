using System;
using System.Collections.Generic;
using System.Text;
using UnitsOfMeasurement.Shared;

namespace UnitsOfMeasurement.Models.MassScales
{
    public interface IMass : IUnit
    {
        Mass Unit { get; }
    }
}
