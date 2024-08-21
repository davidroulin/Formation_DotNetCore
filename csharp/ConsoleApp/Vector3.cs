using System;

public class Vector3 {

	public static Vector3 GenerateRandomVector()
	{
		return new Vector3(1,6,9);
	}



	public float x, y, z;

	public Vector3() {
		// x = 0f; y = 0f; z = 0f;
		
		GenerateRandomVector();

	}

	// overloading de constructeur
	public Vector3(float _x, float _y, float _z)
	{
		x = _x;
		y = _y;
		z = _z;
	}

	public (float, float, float) Deconstruct()
	{
		return (x,y,z);
	}
}
