using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class ExempleCollections
{

	static List<int> listeDeNombres;

	public static void Run() {
		Console.WriteLine("Collections");
		//ExemplesList();
		ExemplesDictionary();
	}

	private class Host
	{
		public string name;
		public string ip;
	}

	private class Connection
	{
		public int port;
		public string protocol;
	}

	public static void ExemplesDictionary()
	{
		Dictionary<string, string> hosts = new Dictionary<string, string>();
		hosts.Add("local", "127.0.0.1");
		hosts.Add("serveur", "192.168.0.3");
		hosts.Add("robot", "192.168.0.4");
	
		foreach (var kv in hosts)
		{
			Console.WriteLine(kv.Value);
		}

		Console.WriteLine(string.Join("\n", hosts.Values));

		Console.WriteLine($"le serveur se trouve a l'adresse : {hosts["serveur"]}");

		Dictionary<Host, Connection> connections = new Dictionary<Host, Connection>();

		Host local = new Host { ip = "127", name = "local" };

		connections.Add(
			local,
			new Connection { port = 443, protocol = "UDP" }
		);

		//connections[local] = new Connection { port = 8888, protocol = "HTTP" };
		connections.TryAdd(
			local,
			new Connection { port = 8888, protocol = "HTTP" }
		);
		connections.TryAdd(
			new Host { ip = "192", name = "robot" },
			new Connection { port = 443, protocol = "TCP" }
		);

		//Console.WriteLine(string.Join('\n', connections));

		IEnumerable<KeyValuePair<Host, Connection>> connectionsLocales = connections.Where(
			(kv) => { return kv.Key.Equals(local); }
		);

		Console.WriteLine(string.Join('\n', connectionsLocales));

		Console.WriteLine("-----------------------------");

		Dictionary<Host, List<Connection>> connectionsMultiples = new Dictionary<Host, List<Connection>>();


		connectionsMultiples[local] = new List<Connection>();
		connectionsMultiples[local].Add( new Connection { port = 443, protocol = "UDP" } );
		connectionsMultiples[local].Add( new Connection { port = 888, protocol = "HTTP" } );

		connectionsMultiples.Add(
			new Host { ip = "192", name = "robot" },
			new List<Connection>()
		);

		connectionsMultiples[
			connectionsMultiples.Keys.ToArray()[1]
		].Add(
			new Connection { port = 443, protocol = "TCP" }
		);

		Console.WriteLine("grr");

	}

	public static void ExemplesList()
	{
	
		listeDeNombres = new List<int>();
		for (int i = 0; i < 200; i++)
		{
			listeDeNombres.Add(i * 10);
		}


		int sommeAvecAggregate = listeDeNombres.Aggregate(
			(intCourant, intSuivant) =>
			{
				// doit retourner un int
				return intCourant + intSuivant;
			}
		);

		Console.WriteLine(sommeAvecAggregate);

		int sommeDirecte = listeDeNombres.Sum();

		Console.WriteLine(sommeDirecte);


		int sommeALancienne1 = 0;
		foreach (int item in listeDeNombres)
		{
			sommeALancienne1 += item;
		}

		Console.WriteLine(sommeALancienne1);



		listeDeNombres.ForEach(
			(int i) =>
			{
				// todo: du code pour chaque element
			}
		);

		// plus besoin
		//Action<int> callback = new Action<int>(FaisUnTrucAvecUnInt);
		//listeDeNombres.ForEach(FaisUnTrucAvecUnInt);


		// TODO
		double[] tableauDeNombres; // = new double[listeDeNombres.Count];
		//tableauDeNombres = listeDeNombres.ToList<double>().ToArray();

	}

	private static void FaisUnTrucAvecUnInt(int nombre)
	{
		Console.WriteLine(nombre);
	}

}
