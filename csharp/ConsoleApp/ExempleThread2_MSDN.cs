using System;
using System.Threading;

public class ExempleThread2_MSDN
{
	[ThreadStatic] static double previous = 0.0;
	[ThreadStatic] static double sum = 0.0;
	[ThreadStatic] static int calls = 0;
	[ThreadStatic] static bool abnormal;
	static int totalNumbers = 0;
	static CountdownEvent countdown;
	private static Object lockObj;
	Random rand;

	public ExempleThread2_MSDN()
	{
		rand = new Random();
		lockObj = new Object();
		countdown = new CountdownEvent(1);
	}

	public static void Main()
	{
		ExempleThread2_MSDN ex = new ExempleThread2_MSDN();
		Thread.CurrentThread.Name = "Main";
		ex.Execute();
		countdown.Wait();
		Console.WriteLine("{0:N0} random numbers were generated.", totalNumbers);
	}

	private void Execute()
	{
		for (int threads = 1; threads <= 10; threads++)
		{
			Thread newThread = new Thread(new ThreadStart(this.GetRandomNumbers));
			countdown.AddCount();
			newThread.Name = threads.ToString();
			newThread.Start();
		}
		this.GetRandomNumbers();
	}

	private void GetRandomNumbers()
	{
		double result = 0.0;

		for (int ctr = 0; ctr < 2000000; ctr++)
		{
			lock (lockObj)
			{
				result = rand.NextDouble();
				calls++;
				Interlocked.Increment(ref totalNumbers);
				// We should never get the same random number twice.
				if (result == previous)
				{
					abnormal = true;
					break;
				} else
				{
					previous = result;
					sum += result;
				}
			}
		}
		// get last result
		if (abnormal)
			Console.WriteLine("Result is {0} in {1}", previous, Thread.CurrentThread.Name);

		Console.WriteLine("Thread {0} finished random number generation.", Thread.CurrentThread.Name);
		Console.WriteLine("Sum = {0:N4}, Mean = {1:N4}, n = {2:N0}\n", sum, sum / calls, calls);
		countdown.Signal();
	}
}
