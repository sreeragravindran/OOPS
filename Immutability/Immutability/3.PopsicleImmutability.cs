using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immutability
{
    public class PopsicleImmutable 
    {
		public bool Frozen { get; private set; }

        private int value; 

		public int Value
        {
			get { return value; }
			set
            {
                if (Frozen)
                    throw new InvalidOperationException("its frozen dammit !!");

                this.value = value;
            }
        }

		public void Freeze()
        {
            Frozen = true;
        }
    }


	public class UsageOfPopsicle
    {
		public static void main()
        {
            var popsicle = new PopsicleImmutable();
            popsicle.Value = 10;
            popsicle.Value = 20;

            popsicle.Freeze();
            popsicle.Value = 30; // bang !! 
        }
    }
}
