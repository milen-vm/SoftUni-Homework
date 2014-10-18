/*
 * Write a program that enters an array of strings and finds in it the largest sequence of equal elements.
 * If several sequences have the same longest length, print the leftmost of them. The input strings
 * are given as a single line, separated by a space.
 * */

import java.util.Scanner;


public class _03_LargestSequenceOfEqualStrings {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("Enter line of words: ");
		String wordsLine = input.nextLine();
		String[] wordsSplitted = wordsLine.split(" ");
		String previousElement = wordsSplitted[0];	
		int sequence = 1;
		int maxSequence = 0;
		int endIndexOfSequence = 0;
		for (int i = 1; i < wordsSplitted.length; i++) {
			String currentElement = wordsSplitted[i];
			if (currentElement.equals(previousElement)) {
				++sequence;
				if (sequence > maxSequence) {
					maxSequence = sequence;
					endIndexOfSequence = i;
				}
			}else {
				sequence = 1;
			}
			previousElement = currentElement;			
		}
		if (maxSequence == 0) {
			System.out.print(wordsSplitted[0]);
		}else {				
			for (int i = endIndexOfSequence; i > endIndexOfSequence - maxSequence; i--) {
				System.out.print(wordsSplitted[i] + " ");
			}
		}

	}

}
