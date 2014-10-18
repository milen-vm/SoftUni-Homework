/*
 * Write a program to check whether a point is inside or outside of the figure below.
 * The point is given as a pair of floating-point numbers, separated by a space.
 * Your program should print "Inside" or "Outside".
 * */

import java.util.Locale;
import java.util.Scanner;

public class _03_PointsInsideFigure {

	public static void main(String[] args) {
		
		Locale.setDefault(Locale.ROOT);
		System.out.print("Point D(x y): ");
		Scanner input = new Scanner(System.in);
		String inputString = input.nextLine();
		String[] coordinates = inputString.split(" ");
		
		double x = Double.parseDouble(coordinates[0]);
		double y = Double.parseDouble(coordinates[1]);
		
		if ((x >= 12.5 && x <= 22.5 && y >= 6 && y <= 8.5) ||
			(x >= 12.5 && x <= 17.5 && y >= 8.5 && y <= 13.5) ||
			(x >= 20 && x <= 22.5 && y >= 8.5 && y <= 13.5)) {
			
			System.out.println("Inside");
		}else {
			System.out.println("Outside");
		}

	}

}
