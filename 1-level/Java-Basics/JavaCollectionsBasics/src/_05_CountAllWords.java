/*
 * Write a program to count the number of words in given sentence. Use any non-letter character as word separator.
 * */

import java.util.Scanner;


public class _05_CountAllWords {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("Enter text: ");
		String textLine = input.nextLine();
		String[] textSplittedString = textLine.split("\\W+");
		System.out.println("Words: " + textSplittedString.length);

	}

}
