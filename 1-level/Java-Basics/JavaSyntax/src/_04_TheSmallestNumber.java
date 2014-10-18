//Write a program that finds the smallest of three numbers.

import java.util.Scanner;

public class _04_TheSmallestNumber {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("a = ");
		double a = input.nextDouble();
		System.out.print("b = ");
		double b = input.nextDouble();
		System.out.print("c = ");
		double c = input.nextDouble();
		if (a <= b && a <= c) {
			System.out.println("Smallest = " + a);
		}else if (b <= a && b <= c) {
			System.out.println("Smallest = " + b);
		}else {
			System.out.println("Smallest = " + c);
		}

	}

}
