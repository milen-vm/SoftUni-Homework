package geometry.shape.space;

import geometry.interfaces.AreaMeasurable;
import geometry.interfaces.VolumeMeasurable;

public class SquarePyramid extends SpaceShape implements AreaMeasurable, VolumeMeasurable {
	private double width;
	private double height;
	private double slantHeight;
	
	public SquarePyramid(double x, double y, double z, double width, double height, double slantHeight) {
		super(x, y, z);
		this.setWidth(width);
		this.setHeight(height);
		this.setSlantHeight(slantHeight);
	}

	public double getWidth() {
		return width;
	}

	public void setWidth(double width) {
		if (width <= 0) {
			throw new IllegalArgumentException("Base width, cannot be zero or negative!");
		}
		
		this.width = width;
	}

	public double getHeight() {
		return height;
	}

	public void setHeight(double height) {
		if (height <= 0) {
			throw new IllegalArgumentException("Heigth, cannot be zero or negative!");
		}
		
		this.height = height;
	}

	public double getSlantHeight() {
		return slantHeight;
	}

	public void setSlantHeight(double slantHeight) {
		if (slantHeight <= 0) {
			throw new IllegalArgumentException("Slant height, cannot be zero or negative!");
		}
		
		this.slantHeight = slantHeight;
	}

	@Override
	public double getVolume() {
		double baseArea = this.width * this.width;
		double volume = (baseArea * this.height) / 3;
		
		return volume;
	}

	@Override
	public double getArea() {
		double basePerimeter = 4 * this.width;
		double baseArea = this.width * this.width;
		double area = ((basePerimeter * this.slantHeight) / 2) + baseArea;
		
		return area;
	}
}
