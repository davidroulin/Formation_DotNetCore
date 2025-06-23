
using MesExtensions;

string s = "cdsjhovnfjos";
s.CoupeLaPremiereLettre()


namespace MesExtensions {


	public static class StringExtensions
	{

		/// <summary>
		/// coucou
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		public static string CoupeLaPremiereLettre(this string s)
		{
			return s.Substring(1);
		}

	}

}