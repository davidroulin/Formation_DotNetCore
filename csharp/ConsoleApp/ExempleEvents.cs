
public class ExempleEvents
{

	public static void Run()
	{
		ExempleToutCustom();

	}

	static void ExempleToutParDefaut()
	{
		// premier snippet sur la page https://learn.microsoft.com/en-us/dotnet/standard/events/#events
	}

	static void ExempleCustomArgsMaisEventHandlerParDefaut()
	{
		// ici https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/events/how-to-publish-events-that-conform-to-net-framework-guidelines#example
		// CustomEventArgs qui derive de EventArgs
		// mais EventHandler par defaut
	}

	static void ExempleToutCustom()
	{
		// ici https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/event#example
		// lui manque le code qui abonne des subscribers
		Publisher pub = new Publisher();
		Subscriber1 sub1 = new Subscriber1();
		Subscriber2 sub2 = new Subscriber2();
		sub1.Abonne(pub);
		sub2.Inscrit(pub);
		pub.RaiseSampleEvent();

	}
	class SampleEventArgs
	{
		public SampleEventArgs(string text) {
			Text = text;
		}
		public string Text { get; } // readonly
	}

	class Publisher
	{
		// Declare the delegate (if using non-generic pattern).
		public delegate void SampleEventHandler(object sender, SampleEventArgs e);

		// Declare the event.
		public event SampleEventHandler SampleEvent;

		// On pourrait en mettre plusieurs
		// ex : bouton 1 clicked, bouton 2 clicked, barre espace pressed
		// ou (plus realiste)
		//			bouton clicked (bouton args = { numero bouton : 1 })
		//			touche pressed (touche args = { char : SPACE }


		// Wrap the event in a protected virtual method
		// to enable derived classes to raise the event.
		public virtual void RaiseSampleEvent()
		{
			// Raise the event in a thread-safe manner using the ?. operator.
			SampleEvent?.Invoke(this, new SampleEventArgs("Hello"));
		}
	}

	class Subscriber1
	{
		public void Abonne(Publisher pub)
		{
			pub.SampleEvent += Pub_SampleEvent;
		}

		private void Pub_SampleEvent(object sender, SampleEventArgs e)
		{
			Console.WriteLine($"Subscriber 1 a recu {e.Text}");
		}
	}

	class Subscriber2
	{
		public void Inscrit(Publisher pub)
		{
			pub.SampleEvent += FaisUnTruc;
		}

		private void FaisUnTruc(object sender, SampleEventArgs e)
		{
			Console.WriteLine($"Je suis subscriber 2 et je fais un truc");
		}
	}

}