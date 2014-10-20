package geometry.shape;

import geometry.vertex.Vertex;

public abstract class Shape {
	protected Vertex[] vertices;

	protected Shape() {
		this.vertices = new Vertex[1];
	}

	public Vertex[] getVertices() {
		return vertices;
	}

	@Override
	public String toString() {
		String str = this.vertices[0].toString();
		
		return str;
	}
	
	protected String getClassName() {
		String fullClassName = this.getClass().toString();
		int indexOfLastDot = fullClassName.lastIndexOf('.');
		String className = fullClassName.substring(indexOfLastDot + 1, fullClassName.length());
		
		return className;
		}
}
