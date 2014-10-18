/*
 * Write a program to find how many times a word appears in given text.
 * The text is given at the first input line. The target word is given at the second input line.
 * The output is an integer number. Please ignore the character casing. Consider that any non-letter
 * character is a word separator. 
 * */

import java.util.Scanner;


public class _06_CountSpecifiedWord {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("Enter text: ");
		String textLine = input.nextLine();
		System.out.print("Target word: ");
		String word = input.nextLine();
		String[] textSplittedString = textLine.split("\\W+");
		int counter = 0;
		for (int i = 0; i < textSplittedString.length; i++) {
			if (word.equalsIgnoreCase(textSplittedString[i])) {
				++counter;
			}
		}
		System.out.println(counter);
	}

}
