using System;
using System.Collections.Generic;
using System.Text;
using UnitsOfMeasurement.Shared;

namespace UnitsOfMeasurement.Models.MassScales
{
    public class Ounce : IUnit
    {
        public Mass Unit { get { return Mass.Ounce; } }
        public double Value { get; set; }

        public string Name => Unit.ToString();
    }

    public class Pound : IUnit
    {
        public Mass Unit { get { return Mass.Pound; } }
        public double Value { get; set; }

        public string Name => Unit.ToString();
    }

    public class Stone : IUnit
    {
        public Mass Unit { get { return Mass.Stone; } }
        public double Value { get; set; }

        public string Name => Unit.ToString();
    }
}
