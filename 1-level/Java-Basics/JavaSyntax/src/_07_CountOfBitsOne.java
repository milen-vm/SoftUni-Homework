/*
 * Write a program to calculate the count of bits 1 in the binary representation of given integer number n.
 * */

import java.util.Scanner;

public class _07_CountOfBitsOne {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("n = ");
		
		int number = input.nextInt();
		int countBitsOne = 0;
		
		for (int i = 0; i < 32; i++) {
			
			int mask = 1 << i;
			int bit = number & mask;
			if (bit != 0) {
				++countBitsOne;
			}
		}
		System.out.println("Count: " + countBitsOne);
		

	}

}
