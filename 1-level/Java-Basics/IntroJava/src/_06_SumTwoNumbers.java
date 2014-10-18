/*
 * Write a program SumTwoNumbers.java that enters two integers from the console,
 *  calculates and prints their sum.
 *  */
import java.util.Scanner;


public class _06_SumTwoNumbers {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		System.out.print("a = ");
		int a = scan.nextInt();
		System.out.print("b = ");
		int b = scan.nextInt();
		System.out.println("a + b = " + (a + b));
				
	}

}
