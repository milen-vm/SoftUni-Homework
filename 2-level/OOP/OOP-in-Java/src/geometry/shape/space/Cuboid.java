package geometry.shape.space;

import geometry.interfaces.AreaMeasurable;
import geometry.interfaces.VolumeMeasurable;

public class Cuboid extends SpaceShape implements AreaMeasurable, VolumeMeasurable {
	private double width;
	private double height;
	private double depth;
	
	public Cuboid(double x, double y, double z, double width, double height, double depth) {
		super(x, y, z);
		this.setWidth(width);
		this.setHeight(height);
		this.setDepth(depth);
	}

	public double getWidth() {
		return width;
	}

	public void setWidth(double width) {
		if (width <= 0) {
			throw new IllegalArgumentException("Width, cannot be zero or negative!");
		}
		
		this.width = width;
	}

	public double getHeight() {
		return height;
	}

	public void setHeight(double height) {
		if (height <= 0) {
			throw new IllegalArgumentException("Height, cannot be zero or negative!");
		}
		this.height = height;
	}

	public double getDepth() {
		return depth;
	}

	public void setDepth(double depth) {
		if (depth <= 0) {
			throw new IllegalArgumentException("Depth, cannot be zero or negative!");
		}
		
		this.depth = depth;
	}

	@Override
	public double getVolume() {
		double volume = this.width * this.depth * this.height;
		
		return volume;
	}

	@Override
	public double getArea() {
		double area = 2 * ((this.width * this.depth) + 
				(this.width * this.height) +
				(this.depth * this.height));
		
		return area;
	}
}
