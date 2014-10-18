/*
 * Write a method to convert from degrees to radians. Write a method to convert from radians to degrees.
 * You are given a number n and n queries for conversion. Each conversion query will
 * consist of a number + space + measure. Measures are "deg" and "rad". Convert all radians to degrees
 * and all degrees to radians. Print the results as n lines, each holding a number + space + measure.
 * Format all numbers with 6 digit after the decimal point.
 * */
import java.util.Scanner;


public class _05_AngleUnitconverter {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("n = ");
		int n = input.nextInt();
		String[] data = new String[n];
		input.nextLine();
		for (int i = 0; i < data.length; i++) {
			//System.out.print((i + 1) + " --> ");
			data[i] = input.nextLine();
		}
		for (int i = 0; i < data.length; i++) {
			String[] splitData = data[i].split(" ");
			double number = Double.parseDouble(splitData[0]);
			String measure = splitData[1];
			if (measure.equals("rad")) {
				convertRadiansToDegrees(number);
			}else {
				convertDegreesToRadians(number);
			}
		}
	}

	private static void convertRadiansToDegrees(double num) {
		double degr = num * 180 / Math.PI;
		System.out.printf("%.6f deg%n", degr);
		
	}

	private static void convertDegreesToRadians(double num) {
		double rad = num * Math.PI / 180;
		System.out.printf("%.6f rad%n", rad);
		
	}

}
