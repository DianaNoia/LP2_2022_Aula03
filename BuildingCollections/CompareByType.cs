using System.Collections.Generic;

namespace BuildingCollections
{
    public class CompareByType : IComparer<Building>
    {
        // True for ascending order, false otherwise
        private bool ord;

        public CompareByType(bool ord)
        {
            this.ord = ord;
        }

        public int Compare(Building x, Building y)
        {
            if (x == y) return 0;
            if (x == null) return -1;
            if (y == null) return 1;
            return ord ? x.Type.CompareTo(y.Type) : y.Type.CompareTo(x.Type);
        }
    }
}