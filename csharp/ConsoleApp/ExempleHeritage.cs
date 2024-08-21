
using System;

//MesMathsDansMonProjet m = new MesMathsDansMonProjet();
//m.cos();

abstract class AbstractMath
{
	public abstract void cos();
}


class Math: AbstractMath
{
	public sealed override void cos()
	{
		Console.WriteLine("le bon");
	}
}



class MesMathsDansMonProjet: Math
{
	public new void cos()
	{
		Console.WriteLine("a moi");
	}
}