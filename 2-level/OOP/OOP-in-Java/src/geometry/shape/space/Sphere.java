package geometry.shape.space;

import geometry.interfaces.AreaMeasurable;
import geometry.interfaces.VolumeMeasurable;

public class Sphere extends SpaceShape implements AreaMeasurable, VolumeMeasurable {
	private double radius;
	
	public Sphere(double x, double y, double z, double radius) {
		super(x, y, z);
		this.setRadius(radius);
	}

	public double getRadius() {
		return radius;
	}

	public void setRadius(double radius) {
		if (radius <= 0) {
			throw new IllegalArgumentException("The sphere radious, cannot be zero or negative!");
		}
		
		this.radius = radius;
	}

	@Override
	public double getVolume() {
		double volume = (4.0 / 3.0) * (Math.PI * Math.pow(this.radius, 3));
		
		return volume;
	}

	@Override
	public double getArea() {
		double area = 4 * Math.PI * this.radius * this.radius;
		
		return area;
	}

}
