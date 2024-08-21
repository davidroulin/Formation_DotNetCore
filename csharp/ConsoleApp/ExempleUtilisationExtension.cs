
using MesExtensions;

class ExempleUtilisationExtension
{

	public string name;

	public string GetNameRaccourci()
	{
		//return name.Substring(1);
		return name.CoupeLaPremiereLettre();
	}

}
