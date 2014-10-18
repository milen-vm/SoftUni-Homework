/*
 * Write a program to find all increasing sequences inside an array of integers.
 * The integers are given in a single line, separated by a space. Print the sequences in the order
 * of their appearance in the input array, each at a single line. Separate the sequence elements by a space.
 * Find also the longest increasing sequence and print it at the last line. If several sequences have the same
 * longest length, print the leftmost of them.
 * */

import java.util.Scanner;


public class _04_LongestIncreasingSequence {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("Enter line of numbers: ");
		String numbersLine = input.nextLine();
		String[] numbersSplitted = numbersLine.split(" ");
		int previousNumber = Integer.parseInt(numbersSplitted[0]);
		int sequence = 1;
		int longestSequence = 1;
		int endIndexOfSequence = 0;
		System.out.print(previousNumber + " ");
		for (int i = 1; i < numbersSplitted.length; i++) {
			int currentnumber = Integer.parseInt(numbersSplitted[i]);	
			if (previousNumber < currentnumber) {
				System.out.print(currentnumber + " ");	
				++sequence;
				if (sequence > longestSequence) {
					longestSequence = sequence;
					endIndexOfSequence = i;
				}
			}else {
				System.out.print("\n" + currentnumber + " ");
				sequence = 1;
			}
			previousNumber = currentnumber;
		}
		System.out.print("\nLongest: ");
		int i = endIndexOfSequence - longestSequence + 1;
		for (; i <= endIndexOfSequence; i++) {
			System.out.print(numbersSplitted[i] + " ");
		}		
	}
}
