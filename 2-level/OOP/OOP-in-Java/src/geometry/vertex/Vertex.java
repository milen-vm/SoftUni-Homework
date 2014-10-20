package geometry.vertex;

public abstract class Vertex {
	private double x;
	private double y;
	
	public Vertex(double x, double y) {
		this.setX(x);
		this.setY(y);
	}
	
	public double getX() {
		return x;
	}
	
	public void setX(double x) {
		this.x = x;
	}
	
	public double getY() {
		return y;
	}
	
	public void setY(double y) {
		this.y = y;
	}
	
	public double calculateDistance(Vertex other){
		double distance = 0;
		double squareDiffX = Math.pow((this.x - other.x), 2);
		double squareDiffY = Math.pow((this.y - other.y), 2);			
		distance = Math.sqrt(squareDiffX + squareDiffY);
		
		return distance;
	}
	
	@Override
	public String toString(){
		String str = "[" + this.x + ", " + this.y  + "]";
		
		return str;
	}
}
