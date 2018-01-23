using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immutability
{
    public class UnsealedPrivateConstructor
    {
        public static UnsealedPrivateConstructor Foo = new Derived1(10);
        public static UnsealedPrivateConstructor Bar = new Derived1(20);

		public int Value { get; }

		private UnsealedPrivateConstructor(int value)
        {
            Value = value;
        }

		private class Derived1 : UnsealedPrivateConstructor
        {
			public int OtherValue { get; set; }

			public Derived1(int value) : base(value)
            {

            }				
        }
    }
}
