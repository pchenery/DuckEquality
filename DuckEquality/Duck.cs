using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckEquality
{
    public class Duck
    {
        public string Name { get; }
        public string Type { get; }
        public int WeightInGrams { get; }
        public int AgeInMonths { get; }
        public static Comparer<Duck> NameComparer { get; } = new NameRelationalComparer();

        public Duck(string name, string type, int weightInGrams, int ageInMonths)
        {
            Name = name;
            Type = type;
            WeightInGrams = weightInGrams;
            AgeInMonths = ageInMonths;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Duck)obj);
        }
        public bool Equals(Duck other)
        {
            return Name == other.Name &&
                   Type == other.Type &&
                   WeightInGrams == other.WeightInGrams &&
                   AgeInMonths == other.AgeInMonths;
        }

        public static bool operator == (Duck left, Duck right)
        {
            return Equals(left, right);
        }
        public static bool operator != (Duck left, Duck right)
        {
            return !Equals(left, right);
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = (hash * 23) + Name.GetHashCode();
            hash = (hash * 23) + Type.GetHashCode();
            hash = (hash * 23) + WeightInGrams.GetHashCode();
            return hash;
        }
        public override string ToString()
        {
            return $"{Name}, Breed {Type}, Age {AgeInMonths}, weight {WeightInGrams}";
        }

        private sealed class NameRelationalComparer : Comparer<Duck>
        {
            public override int Compare(Duck x, Duck y)
            {
                if (ReferenceEquals(x, y)) return 0;
                if (ReferenceEquals(null, y)) return 1;
                if (ReferenceEquals(null, x)) return -1;
                return x.Name.CompareTo(y.Name);
            }
        }
    }

}
