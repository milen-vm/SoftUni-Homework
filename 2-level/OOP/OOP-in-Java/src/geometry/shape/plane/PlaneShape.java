package geometry.shape.plane;

import geometry.interfaces.AreaMeasurable;
import geometry.interfaces.PerimeterMeasurable;
import geometry.shape.Shape;
import geometry.vertex.Vertex2D;

public abstract class PlaneShape extends Shape implements PerimeterMeasurable, AreaMeasurable {
	public PlaneShape(double x, double y) {
		this.vertices = new Vertex2D[3];
		this.vertices[0] = new Vertex2D(x, y);
	}
	
	@Override
	public abstract double getArea();

	@Override
	public abstract double getPerimeter();
	
	@Override
	public String toString() {
		String str = "Shape Type: " + this.getClassName() +
				"\nArea: " + this.getArea() +
				"\nPerimeter: " + this.getPerimeter() + "\n" +
				super.toString();
		
		return str;
	}

}
