/*
 * Write a program to check whether a point is inside or outside the house below.
 * The point is given as a pair of floating-point numbers, separated by a space.
 * Your program should print "Inside" or "Outside".
 * */

import java.util.Scanner;

public class _09_PointsInsideTheHouse {

	public static void main(String[] args) {	
		
		System.out.print("Point D(x y): ");
		Scanner input = new Scanner(System.in);
		String inputString = input.nextLine();
		String[] coordinates = inputString.split(" ");
		
		double xD = Double.parseDouble(coordinates[0]);
		double yD = Double.parseDouble(coordinates[1]);
		
		if ((isInTheTriangle(xD, yD)) ||
			(xD >= 12.5 && xD <= 17.5 && yD >= 8.5 && yD <= 13.5) ||
			(xD >= 20 && xD <= 22.5 && yD >= 8.5 && yD <= 13.5)) {
			
			System.out.println("Inside");
			
		}else {
			
			System.out.println("Outside");
		}

	}
	public static boolean isInTheTriangle(double xD, double yD){		
		
		double areaTriangleABD = calculateTriangleArea(12.5, 8.5, 22.5, 8.5, xD, yD);
		double areaTriangleBCD = calculateTriangleArea(22.5, 8.5, 17.5, 3.5, xD, yD);
		double areaTriangleCAD = calculateTriangleArea(17.5, 3.5, 12.5, 8.5, xD, yD);
		//double areaTriangleABC = calculateTriangleArea(12.5, 8.5, 22.5, 8.5, 17.5, 3.5);
		double areaTriangleABC = 25.0f;
		//System.out.println("ABC area " + areaTriangleABC);
		
		if (areaTriangleABD + areaTriangleBCD + areaTriangleCAD == areaTriangleABC) {
			
			return true;
			
		}else {
			
			return false;
		}
	}
	
	public static double calculateTriangleArea(double xA, double yA, double xB, double yB, double xC, double yC){
		
		double area = Math.abs((xA * (yB - yC) + xB * (yC - yA) + xC * (yA - yB)) / 2);
		return area;
	}

}
