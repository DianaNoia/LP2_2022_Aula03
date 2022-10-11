using System;

namespace BuildingCollections
{
    public class Building : IHasValue, IComparable<IHasValue>
    {
        public string Type { get; }
        public float Value { get; }
        public float Area { get; }

        public Building(string type, float value, float area)
        {
            Type = type;
            Value = value;
            Area = area;
        }

        public override string ToString() =>
            $"{Type,-20}{Value,8:f2}${Area,8:f2}m2";

        public bool Equals(IHasValue other)
        {
            if (other is null) return false;
            return Value == other.Value;
        }

        public int CompareTo(IHasValue other)
        {
            // Nulls always come first in sorting
            if (other == null) return 1;
            if (Value < other.Value) return 1;
            if (Value > other.Value) return -1;
            return 0;
        }
    }
}