/*
 * Write a program that enters 3 points in the plane (as integer x and y coordinates),
 * calculates and prints the area of the triangle composed by these 3 points.
 * Round the result to a whole number. In case the three points do not form a triangle, print "0" as result.
 * */

import java.util.Scanner;

public class _02_TriangleArea {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		
		System.out.println("Point \"A\":");
		System.out.print("x = ");
		double xA = input.nextDouble();
		System.out.print("y = ");
		double yA = input.nextDouble();
		
		System.out.println("Point \"B\":");
		System.out.print("x = ");
		double xB = input.nextDouble();
		System.out.print("y = ");
		double yB = input.nextDouble();
		
		System.out.println("Point \"C\":");
		System.out.print("x = ");
		double xC = input.nextDouble();
		System.out.print("y = ");
		double yC = input.nextDouble();
		
		double area = Math.abs((xA * (yB - yC) + xB * (yC - yA) + xC * (yA - yB)) / 2);
		System.out.printf("Area = %.0f%n", area);
		

	}

}
