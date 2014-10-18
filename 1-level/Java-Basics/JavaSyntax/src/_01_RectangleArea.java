/*
 * Write a program that enters the sides of a rectangle (two integers a and b)
 * and calculates and prints the rectangle's area.
 * */

import java.util.Scanner;

public class _01_RectangleArea {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("a = ");
		int a = input.nextInt();
		System.out.print("b = ");
		int b = input.nextInt();
		System.out.println("Area = " + (a * b));

	}

}
