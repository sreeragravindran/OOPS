namespace Immutability
{
    public class Mutable 
	{
		public int Value { get; set; }
	}

	public class UsageOfMutable
    {
		public static void main()
        {
            var mutable = new Mutable();
            mutable.Value = 10;
            mutable.Value = 20;
        }
    }
}
