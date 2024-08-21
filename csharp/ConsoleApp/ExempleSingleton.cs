

class Client {
	public Service serviceUtilise;
}

class Service {
	public string nom;
}

// lui onb veut que ce soit un singleton
class OrganisateurGeneral {



	private static OrganisateurGeneral _realInstance;

	public static OrganisateurGeneral Singleton
	{
		get
		{
			return _realInstance ?? new OrganisateurGeneral().Init();
		}
	}

	private OrganisateurGeneral Init()
	{
		clients = new List<Client>();
		services = new List<Service>();
		return this;
	}







	//private static OrganisateurGeneral _realInstance;

	//public static OrganisateurGeneral Singleton
	//{
	//	get
	//	{
	//		if (_realInstance == null)
	//		{
	//			_realInstance = new OrganisateurGeneral();
	//			_realInstance.Init();
	//		}
	//		return _realInstance;
	//	}
	//}

	//private void Init() {
	//	clients = new List<Client>();
	//	services = new List<Service>();
	//}






	//public static OrganisateurGeneral instance = new OrganisateurGeneral();

	//private OrganisateurGeneral() {
	//	if (instance == null)
	//	{
	//		instance = new OrganisateurGeneral();
	//	}
	//	clients = new List<Client> ();
	//	services = new List<Service> ();
	//}





	public List<Client> clients;

	public List<Service> services;

	public void Abonne(Client c, Service s) { c.serviceUtilise = s; }


}
