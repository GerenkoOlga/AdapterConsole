using System;

namespace AdapterConsole
{
	/// <summary>
	/// Summary description for MallardDuck.
	/// </summary>
	public class MallardDuck : IDuck
	{
		public MallardDuck()
		{}

		#region Duck Members

		public string Quack()
		{
			return "Quack";
		}

		public string Fly()
		{
			return "I'm flying";
		}

		#endregion
	}
}
