package geometry.shape.space;

import geometry.interfaces.AreaMeasurable;
import geometry.interfaces.VolumeMeasurable;
import geometry.shape.Shape;
import geometry.vertex.Vertex3D;

public abstract class SpaceShape extends Shape implements AreaMeasurable, VolumeMeasurable {
	public SpaceShape(double x, double y, double z) {
		this.vertices = new Vertex3D[1];
		this.vertices[0] = new Vertex3D(x, y, z);
	}
	@Override
	public abstract double getVolume();

	@Override
	public abstract double getArea();
	
	@Override
	public String toString() {
		String str = "Shape type: " + this.getClassName() +
				"\nArea: " + this.getArea() + "\n" +
				"Volume: " + this.getVolume() + "\n" +
				super.toString();
		
		return str;
	}

}
