using System;


class Vector4 {

	public float x, y, z, w;



	public Vector4() {
		x = 0f; y = 0f; z = 0f; w = 0f;
	}

	// overloading de constructeur
	public Vector4(float _x, float _y, float _z, float _w)
	{
		x = _x;
		y = _y;
		z = _z;
		w = _w;
		//this.w = w; // si elles ont le meme nom
	}

	public Vector4(Vector2 vector)
	{
		x = vector.x;
		y = vector.y;
		z = 0f; w = 0f;
	}
}
