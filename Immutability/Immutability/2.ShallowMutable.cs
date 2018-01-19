using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immutability
{
    public class ShallowMutable
    {
        // immutable 
        public int Value { get; }

        // mutable 
        public StringBuilder NameBuilder { get; }

        public ShallowMutable(int value, StringBuilder nameBuilder)
        {
            Value = value;
            NameBuilder = nameBuilder;
        }
    }


    public class UsageOfShallowImmutable
    {
        public static void main()
        {
            var nameBuilder = new StringBuilder();
            var shallowMutable = new ShallowMutable(10, nameBuilder);

            nameBuilder.Append("foo");
            shallowMutable.NameBuilder.Append("bar");
            Console.WriteLine(shallowMutable.NameBuilder.ToString());
        }
    }
}
