

class MonClient {
	public MonService serviceUtilise;
}

class MonService {
	public string nom;
}

// lui onb veut que ce soit un singleton
class MonOrganisateurGeneral {



	private static MonOrganisateurGeneral _realInstance;

	public static MonOrganisateurGeneral Singleton
	{
		get
		{
			return _realInstance ?? new MonOrganisateurGeneral().Init();
		}
	}

	private MonOrganisateurGeneral Init()
	{
		clients = new List<MonClient>();
		services = new List<MonService>();
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





	public List<MonClient> clients;

	public List<MonService> services;

	public MonService serviceParDefaut;

	public void Abonne(MonClient c, MonService s) { c.serviceUtilise = s; }

	public void Abonne(MonClient c)
	{
		Abonne(c, serviceParDefaut);
	}


}
