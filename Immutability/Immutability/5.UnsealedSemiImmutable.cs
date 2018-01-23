using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immutability
{
   public class UnsealedSemiImmutable 
    {
		public int Value { get; }

		public UnsealedSemiImmutable(int value)
        {
            Value = value;
        }
    }


	public class DerivedMutable : UnsealedSemiImmutable
    {
		public int OtherValue { get; set; }

		public DerivedMutable(int value) : base(value)
        {			
        }
    }


	public class ExampleOfUnsealedImmutable
    {
		private UnsealedSemiImmutable believedToBeImmutable { get; }

		public ExampleOfUnsealedImmutable(UnsealedSemiImmutable immutable)
        {
            believedToBeImmutable = immutable;
        }

		public static void main()
        {
            var naughty = new DerivedMutable(10);
            var example = new ExampleOfUnsealedImmutable(naughty);
            naughty.OtherValue = 20;
        }

    }
}
