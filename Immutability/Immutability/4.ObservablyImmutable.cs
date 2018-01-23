using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immutability
{
    public sealed class ObservablyImmutable
    {
        private int cachedHash; 

        public string Name { get; }

        public ObservablyImmutable(string name)
        {
            Name = name;
        }

        public override bool Equals(object obj)
        {
            var other = obj as ObservablyImmutable;
            if (other == null)
                return false;

            return other.Name == Name;
        }

        public override int GetHashCode()
        {
            if (cachedHash == 0)
                cachedHash = Name.GetHashCode();

            return cachedHash; 
        }
    }
}
