using System;
using System.Text;

namespace AdapterConsole
{
	/// <summary>
	/// Summary description for TurkeyAdapter.
	/// </summary>
	public class TurkeyAdapter : IDuck
	{
		ITurkey turkey;

		public TurkeyAdapter(ITurkey turkey)
		{
			this.turkey = turkey;
		}

		#region Duck Members

		public string Quack()
		{
			return turkey.Gobble();
		}

		public string Fly()
		{
			StringBuilder sb = new StringBuilder();

			for(int i = 0; i < 5; i++)
			{
				sb.Append(turkey.Fly());
				sb.Append("\n");
			}
			return sb.ToString();
		}

		#endregion
	}
}
