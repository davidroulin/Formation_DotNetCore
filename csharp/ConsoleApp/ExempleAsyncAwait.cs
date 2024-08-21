
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class ExempleAsyncAwait
{

	static int TIMEOUT = 10000;
	static int TASK01_DURATION = 3000;
	static int TASK02_DURATION = 5000;

	public static async Task Run()
	{
		Console.WriteLine("async await");
		
		//await ExempleAttendToutLeMonde();
		//await ExempleAttendPasLa2();
		//await ExempleAttendPersonne();

		//await ExempleAttendToutes(); // (WhenAll) sans timeout
		await ExempleTimeout(); // (WhenAny) attend toutes mais avec en plus un timeout
	
	}

	public static async Task ExempleAttendToutLeMonde()
	{
		Tache01(); // lance tache 01 ...
		await Tache02(); // ... et 02 en parrallele, et attend la 2
						 // (attention si la 1 finit apre sla 2 on ne verra pas la fin de la 1)
	}

	public static async Task ExempleAttendPasLa2()
	{
		await Tache01(); // bloque, une fois tache 01 terminee, lance tache 02
		Tache02(); // mais n'attend pas
	}

	public static async Task ExempleAttendPersonne()
	{
		Tache01();
		Tache02();
	}

	static async Task Tache01()
	{
		await Task.Delay(TASK01_DURATION);
		Console.WriteLine("tache 01 terminee");
	}

	static async Task Tache02()
	{
		await Task.Delay(TASK02_DURATION);
		Console.WriteLine("tache 02 terminee");
	}


	// Timeout
	public static async Task ExempleTimeout()
	{
		await Task.WhenAny(
			ExempleAttendToutes(),
			Task.Delay(TIMEOUT)
		);
	}

	public static async Task ExempleAttendToutes()
	{
	// Attend plusieurs taches sans connaitre l'ordre prevu de retour
		await Task.WhenAll(new Task[] {
			Tache01(),
			Tache02()
		});
	}


}
