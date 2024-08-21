//ExempleXML.Run();

//ExempleThread.Run();

//ExempleThread2_MSDN.Main();

//// ---------------------------------------

//// ici on se parle a nous meme
//async Task TestEcouteBlocking()
//{
//	await Task.Delay(50);
//	ExempleReseau1.UDPListenerBlocking listener = new ExempleReseau1.UDPListenerBlocking();
//	listener.Receive();
//}


//async Task TestEcouteAsync()
//{
//	ExempleReseau1.UDPListenerAsync listener = new ExempleReseau1.UDPListenerAsync();
//	await listener.Receive();
//}

//async Task TestEnvoie()
//{
//	await Task.Delay(1000);
//	ExempleReseau1.UDPSender.Send("salut");
//}

//async Task TestAsync()
//{
//	await Task.WhenAll(
//		TestEcouteAsync(),
//		TestEnvoie()
//	);
//}

//async Task TestBlocking()
//{
//	await Task.WhenAll(
//		TestEcouteBlocking(),
//		TestEnvoie()
//	);
//}


////await TestAsync();
////await TestBlocking();

//// -------------------------------------------

//// ici on se parle a deux sur le reseau

//async Task EcouteBlocking()
//{
//	ExempleReseau1.UDPListenerBlocking listener = new ExempleReseau1.UDPListenerBlocking();
//	listener.Receive();
//}


//async Task EcouteAsync()
//{
//	ExempleReseau1.UDPListenerAsync listener = new ExempleReseau1.UDPListenerAsync();
//	await listener.Receive();
//}

//async Task Envoie()
//{
//	ExempleReseau1.UDPSender.Send("salut");
//}





//ExempleCollections.Run();

//await ExempleAsyncAwait.Run();

//ExempleEvents.Run();



//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//int? monEntier = null;

////int autreEntier = monEntier;

//// ternary operator condition
//int autreEntier = (monEntier == null) ? 7 : monEntier.Value;
//// null coalescing operator
//int autreEntier2 = monEntier ?? 7;

//// pareil, se debarasse de la nullabilite du type, mais en renvoyant la valeur par defaut du type simple (0, string vide "", etc)
//monEntier.GetValueOrDefault();

//Console.WriteLine(autreEntier);

//double a = 13.5;
//float c = (float) a;

//// value type, assignement = copie
//double a_copie = a;
//a = 89.345;
//Console.WriteLine(a_copie); // a_copie est toujours = 13.5
//Console.WriteLine(a);

//// reference type, assignement = meme ref
//Point p1 = new Point();
//p1.x = 13.5f;
//p1.y = 3f;
//Point p2 = p1;
//p1.x = 8f;
//Console.WriteLine(p2.x); // affiche 8.0f

//// boxing unboxing
//int unEntierSimple = 0;
//object unEntierBoxe = unEntierSimple; // boxing
//object unEntierBoxe_copie = unEntierBoxe;
//Console.WriteLine("-- ");
//Console.WriteLine("unEntierSimple = " + unEntierSimple);
//Console.WriteLine("unEntierBoxe = " + unEntierBoxe);
//Console.WriteLine("unEntierBoxe_copie = " + unEntierBoxe_copie);
//Console.WriteLine("-- ");
//unEntierSimple = 3;
//Console.WriteLine("unEntierSimple = " + unEntierSimple);
//Console.WriteLine("unEntierBoxe = " + unEntierBoxe);
//Console.WriteLine("unEntierBoxe_copie = " + unEntierBoxe_copie);
//Console.WriteLine("-- ");
//unEntierBoxe = 4;
//Console.WriteLine("unEntierSimple = " + unEntierSimple);
//Console.WriteLine("unEntierBoxe = " + unEntierBoxe);
//Console.WriteLine("unEntierBoxe_copie = " + unEntierBoxe_copie);
//Console.WriteLine("-- ");

//Point p3 = new Point();
//object qqchose;
//qqchose = p3;

//Rotation r1 = new EulerRotation();
//Rotation r2 = new QuaternionRotation();
////Rotation r3 = new Rotation(); // je peux pas car abstract

//Vector3 repere01 = new Vector3(1, 0, 1);

//Vector3 repere02 = new Vector3(8, 6, 4);

////repere01.

//Vector3.GenerateRandomVector();



//Point Tourne(Point p) {
//	return new Point { x = p.x * 3, y = p.y /2 };
//}

//Point Decale(Point p) {
//	return new Point { x = p.y, y = p.x };
//}

//void Nullifie(Point p) {
//	p.x = 0; p.y = 0;
//}


//Transforme uneTransformationQuiMatcheLaSignature1 = Tourne;
//Transforme uneTransformationQuiMatcheLaSignature2 = Decale;
////Transforme uneTransformationQuiMatcheLaSignature3 = Nullifie; // marche pas car ne respecte pas la signature attendue

//Point pointTestDelegate = new Point { x = 5.0f, y = 4.0f };

//Tourne(pointTestDelegate); // facon classique d'invoquer la methode
//uneTransformationQuiMatcheLaSignature1.Invoke(pointTestDelegate); // meme resultat, facon d'invoquer par delegate
//																  // interet ? pouvoir avoir du code qui appelle une methode, sans savoir a l'avance quelle sera cette methode
//																  // (la methode elle-meme devient un argument, une reference)


////pointTestDelegate.ForcerValeur(); // je dois fournir cette valeur
//pointTestDelegate.ForcerValeur(4);
//pointTestDelegate.ForcerValeur(4, true);


//Console.WriteLine(Chien.races);


//// template method


//void print<T>(T qqchose)
//{
//	Console.WriteLine(qqchose);
//}

//T faitUnPetit<T>(T maman, T papa) where T : Animal
//{
//	T petit = papa;
//	petit.race = maman.race;
//	return petit;
//}

//Chien mamanChien = new Chien();
//Chien papaChien = new Chien();

//Oiseau mamanOiseau = new Oiseau();
//Oiseau papaOiseau = new Oiseau();

//Chien bebeChien = faitUnPetit<Chien>(mamanChien, papaChien);
//Oiseau bebeOiseau = faitUnPetit<Oiseau>(mamanOiseau, papaOiseau);



//Vector3 repere03 = new Vector3(1, 0, 1);
//float leX, leY, leZ;
//(leX, leY, leZ) = repere03.Deconstruct();

//StateMachineABaseDeTuples stm = new StateMachineABaseDeTuples();
//stm.SetExample3();
//stm.StateMachineDecideWhatNext();


//ExempleStructAvecRefs.Run();



//delegate Point Transforme(Point p);


//partial class Point
//{
//	public float x;
//	public float y;

//	public string name;

//	public override bool Equals(object? obj)
//	{
//		return base.Equals(obj);
//	}

//	public void EnvisageDeFaire(TransformationGeometrique t)
//	{

//	}

//	// method overloading : version 1
//	public void MiseAZero(bool trace) {
//		if (trace) {
//			Console.WriteLine("mise a zero du point " + name);
//		}
//		x = 0; y = 0;
//	}

//	// method overloading : version 2
//	public float MiseAZero()
//	{
//		return 0f;
//	}

//	// method overloading : version pas possible car memes arguments donc confusion du compilateur
//	//public float MiseAZero(bool trace)
//	//{
//	//	return 0f;
//	//}

//	public void ForcerValeur(float valeur, bool trace = false)
//	{
//		if (trace)
//		{
//			Console.WriteLine("mise a zero du point " + name);
//		}
//		x = valeur; y = valeur;
//	}

//}


//abstract class Rotation {
//	protected string name;
//	public string GetName() { return name;  }
//	public abstract void Apply(Point p);
//	public virtual void Transform(Rotation r) { }
//}

//class EulerRotation : Rotation {
//	public float x, y, z;

//	public override void Apply(Point p) { }
//	public override void Transform(Rotation r) { }

//	// a peux pas // public override string GetName() { return "NAME: " + name; }
//	new public string GetName() { return "NAME: " + name; }
//}

//partial class Point
//{
//	public string nickname;
//}

//class QuaternionRotation : Rotation {
//	public float a, b, c, d;
//	public override void Apply(Point p) { }
//}

//interface TransformationGeometrique
//{
//	public string Description()
//	{
//		return ""; // oui on peut mettre du code dans les interfaces
//	}
//}

//interface OperationMathematique
//{
//	public void DescribeWhatYouWouldDo(object o);
//}

//// DERIVE (inherits) de la classe abstraite (parente) Rotation
//// IMPLEMENTE les interfaces TransformationGeometrique, OperationMathematique
//class ParametricRotation: Rotation, TransformationGeometrique, OperationMathematique
//{
//	public override void Apply(Point p)
//	{
//		throw new NotImplementedException();
//	}

//	public void DescribeWhatYouWouldDo(object o)
//	{
//		throw new NotImplementedException();
//	}

//	public string Description()
//	{
//		throw new NotImplementedException();
//	}
//}


//interface Baveur
//{
//	public void Bave() { }
//}

//interface Mordeur
//{
//	public void Mord() { }
//}

//interface Volant
//{
//	public void Vole() { }
//}
//class Animal { public string race; }
//class Chien : Animal, Mordeur, Baveur {
//	public static string races = "Labrador, Cocker";
//}
//class Oiseau : Animal, Mordeur, Volant { }

