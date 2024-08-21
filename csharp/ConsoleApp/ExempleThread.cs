using System;
using System.Threading;

public class ExempleThread
{

	[ThreadStatic]
	static int variabPartagee;

	public static void Run()
	{

		variabPartagee = 0;

		Thread t1 = new Thread(FaisUnTrucDansMonDos);
		t1.Name = "Jacqouille";
		t1.Start();

		Thread t2 = new Thread(LaPetiteSoeur);
		t2.Name = "Florent";
		t2.Start();

		t2.Join();
		t1.Join();

		Console.WriteLine($"{Thread.CurrentThread.Name} .variabPartagee = {variabPartagee}");
		
	}

	public int counter = 0;

	public static void FaisUnTrucDansMonDos()
	{
		ExempleThread exemple = new ExempleThread();
		while (exemple.counter < 400)
		{
			Thread.Sleep(25);
			exemple.counter++;
			variabPartagee++;
		}
		Console.WriteLine($"{Thread.CurrentThread.Name} .counter = {exemple.counter}");
	}

	public static void LaPetiteSoeur()
	{
		ExempleThread exemple = new ExempleThread();
		while (exemple.counter < 300)
		{
			Thread.Sleep(25);
			exemple.counter++;
			variabPartagee++;
		}
		Console.WriteLine($"{Thread.CurrentThread.Name} .counter = {exemple.counter}");
	}



}
