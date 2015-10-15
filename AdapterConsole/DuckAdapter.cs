using System;
using System.Text;

namespace AdapterConsole
{
	/// <summary>
	/// Summary description for TurkeyAdapter.
	/// </summary>
	public class DuckAdapter : ITurkey
	{
		IDuck duck;

		public DuckAdapter(IDuck duck)
		{
			this.duck = duck;
		}

		#region Turkey Members

		public string Gobble()
		{
			return duck.Quack();
		}

		public string Fly()
		{
			return duck.Fly();
		}

		#endregion
	}
}
