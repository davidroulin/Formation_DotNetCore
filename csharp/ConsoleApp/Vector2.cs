using System;

public class Vector2 : AVector {

	public float x, y;

	public Vector2() {
	}

	public Vector2(float x, float y)
	{
		this.x = x;
		this.y = y;
	}

	public override string Values()
	{
		//return "( " + x + ", " + y + " )"; // a l'ancienne
		return $"( {x}, {y} )"; // .NET 6+ : string interpolees
	}
}
