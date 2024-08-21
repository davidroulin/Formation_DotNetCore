

public class StateMachineABaseDeTuples {

	(int, int, string) etat;

	public void SetExample1()
	{
		etat = (1, 5, "x");
	}

	public void SetExample3()
	{
		etat = (1, 2, "z");
	}


	public void StateMachineDecideWhatNext()
	{
		switch (etat)
		{
			case (1, 5, "x"):
				Console.WriteLine("cas 1");
				break;
			case (3, 8, "y"):
				Console.WriteLine("cas 2");
				break;
			case (_, 2, _):
				Console.WriteLine("cas 3");
				break;
			default:
				break;

		}
	}

}
