package geometry.shape.plane;

import geometry.vertex.Vertex;
import geometry.vertex.Vertex2D;

public class Triangle extends PlaneShape {
	private double lengthAB;
	private double lengthAC;
	private double lengthBC;

	public Triangle(double x1, double y1, double x2, double y2, double x3, double y3) {
		super(x1, y1);
		this.vertices[1] = new Vertex2D(x2, y3);
		this.vertices[2] = new Vertex2D(x3, y3);
		
		this.lengthAB = setSideLength(this.vertices[0], this.vertices[1]);
		this.lengthAC = setSideLength(this.vertices[0], this.vertices[2]);
		this.lengthBC = setSideLength(this.vertices[1], this.vertices[2]);
		
		this.isValidTriangle();
	}

	private void isValidTriangle(){
		boolean sideBCtoA = this.lengthAB + this.lengthAC > this.lengthBC;
		boolean sideACtoB = this.lengthBC + this.lengthAB > this.lengthAC;
		boolean sideABtoC = this.lengthBC + this.lengthAC > this.lengthAB;
		boolean isValidTriangle = sideABtoC && sideACtoB && sideBCtoA;
		
		if (!isValidTriangle) {
			throw new IllegalArgumentException("Invalid triangle!");
		}
	}
	
	private double setSideLength(Vertex vertexOne, Vertex vertexTwo){
		double length = vertexOne.calculateDistance(vertexTwo);
		
		return length;
	}
	
	@Override
	public double getArea() {
		double halfPerimeter = this.getPerimeter() / 2;
		double area = Math.sqrt(halfPerimeter *
				(halfPerimeter - this.lengthAB) *
				(halfPerimeter - this.lengthAC) *
				(halfPerimeter - this.lengthBC));
		
		return area;
	}

	@Override
	public double getPerimeter() {
		double perimeter = this.lengthAB + this.lengthAC + this.lengthBC;
		
		return perimeter;
	}
}
