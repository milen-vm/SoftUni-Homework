package geometry.vertex;


public class Vertex3D extends Vertex {

	private double z;
	
	public Vertex3D(double x, double y, double z) {
		super(x, y);
		this.setZ(z);
	}
	
	public double getZ() {
		return z;
	}
	
	public void setZ(double z) {
		this.z = z;
	}
	
	@Override
	public String toString(){
		String str = "[" + this.getX() + ", " + this.getY() + ", " + this.z + "]";
		
		return str;
	}

}
