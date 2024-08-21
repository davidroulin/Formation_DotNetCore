
//Dimensions2D dims = new Dimensions2D();
//dims.Width = 4;

//dims.width


public class Dimensions2D : Vector2 {

	public float Width {
		get {
			return this.x;
		}
		set {
			this.x = value;
		}
		//init {
		//	this.x = 0;
		//}
	}
	public float Height {
		get {
			return this.y;
		}
		set {
			this.y = value;
		}
		//init {
		//	this.x = 0;
		//}
	}

	public override string Values() {
		return $" {x} by {y} ";
	}

}
