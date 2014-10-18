/*
 * Write a program to generate and print all symmetric numbers in given range [start…end].
 * A number is symmetric if its digits are symmetric toward its middle. For example,
 * the numbers 101, 33, 989 and 5 are symmetric, but 102, 34 and 997 are not symmetric.
 * */

import java.util.Scanner;

public class _01_SymmetricNumbersInRange {

	public static void main(String[] args) {
		
		//Locale.setDefault(Locale.ROOT);
		Scanner input = new Scanner(System.in);
		System.out.print("Range start: ");
		int start = input.nextInt();
		System.out.print("Range end: ");
		int end = input.nextInt();
		
		for (int i = start; i <= end; i++) {
			
			String number = Integer.toString(i);
			boolean isSymmetric = true;
			
			for (int j = 0; j < number.length() / 2; j++) {	
				
				if (number.charAt(j) != number.charAt(number.length() - 1 - j)) {
					
					isSymmetric = false;
					break;
				}
			}
			if (isSymmetric) {
				
				System.out.print(number + " ");
			}
		}

	}

}
