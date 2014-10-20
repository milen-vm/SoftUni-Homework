package geometry.shape.plane;


public class Circle extends PlaneShape {
	private double radius;
	
	public Circle(double x, double y, double radius) {
		super(x, y);
		this.setRadius(radius);
	}

	public double getRadius() {
		return radius;
	}

	public void setRadius(double radius) {
		if (radius <= 0) {
			throw new IllegalArgumentException("The circle radius, cannot be zero or negative!");
		}
		
		this.radius = radius;
	}
	
	@Override
	public double getArea() {
		double area = Math.PI * this.radius * this.radius;
		
		return area;
	}

	@Override
	public double getPerimeter() {
		double perimeter = 2 * Math.PI * this.radius;
		
		return perimeter;
	}

}
