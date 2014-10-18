/*
 * Write a program to find how many times given string appears in given text as substring.
 * The text is given at the first input line. The search string is given at the second input line.
 * The output is an integer number. Please ignore the character casing.
 * */

import java.util.Scanner;


public class _07_CountSubstringOccurrences {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("Enter text: ");
		String textLine = input.nextLine().toLowerCase();
		System.out.print("Substring: ");
		String subString = input.nextLine().toLowerCase();
		//String[] textSplittedString = textLine.split("\\W+");
		int counter = 0;
		for (int i = 0; i <= textLine.length() - subString.length(); i++) {
			boolean isContainsSubString = textLine.substring(i, subString.length() + i).contains(subString);
			if (isContainsSubString) {
				++counter;
			}
		}
		System.out.println(counter);
	}

}
