
	struct ReferencePoint
	{
		public Vector3 position;
		public string name;
	}

	internal class ExempleStructAvecRefs
	{

		public static void Run()
		{
			var refPointSol = new ReferencePoint
			{
				position = new Vector3(0,0,3),
				name = "origine bras sol"
			};

			var refPointCoude = refPointSol;
			refPointCoude.name = "origine coude";

			Console.WriteLine(refPointSol.position.z); // 3
			Console.WriteLine(refPointCoude.position.z); // 3

			Console.WriteLine(refPointSol.name); // sol
			Console.WriteLine(refPointCoude.name); // coude

			refPointSol.position.z = 7;

			Console.WriteLine(refPointSol.position.z); // ?
			Console.WriteLine(refPointCoude.position.z); // ?

	}


	}

