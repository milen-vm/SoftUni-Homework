package geometry.shape.plane;


public class Rectangle extends PlaneShape {
	private double width;
	private double height;
	
	public Rectangle(double x, double y, double width, double height) {
		super(x, y);
		this.setWidth(width);
		this.setHeight(height);
	}

	public double getWidth() {
		return width;
	}

	public void setWidth(double width) {
		if (width <= 0) {
			throw new IllegalArgumentException("The rectangle width, cannot be zero or negative!");
		}
		
		this.width = width;
	}

	public double getHeight() {
		return height;
	}

	public void setHeight(double height) {
		if (height <= 0) {
			throw new IllegalArgumentException("The rectangle height, cannot be zero or negative!");
		}
		
		this.height = height;
	}

	@Override
	public double getArea() {
		double area = this.width * this.height;
		
		return area;
	}

	@Override
	public double getPerimeter() {
		double perimeter = (2 * this.width) + (2 * this.height);
		
		return perimeter;
	}

}
