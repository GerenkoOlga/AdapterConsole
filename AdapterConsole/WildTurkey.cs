using System;

namespace AdapterConsole
{
	/// <summary>
	/// Summary description for WildTurkey.
	/// </summary>
	public class WildTurkey : ITurkey
	{
		public WildTurkey()
		{}

		#region Turkey Members

		public string Gobble()
		{
			return "Gooble, gooble";
		}

		public string Fly()
		{
			return "I'm flying a short distance";
		}

		#endregion
	}
}
