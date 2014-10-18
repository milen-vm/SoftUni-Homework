/*
 * At the first line at the console you are given a piece of text. Extract all words from it and print them in alphabetical order.
 * Consider each non-letter character as word separator. Take the repeating words only once.
 * Ignore the character casing. Print the result words in a single line, separated by spaces.
 * */

import java.util.Scanner;
import java.util.Set;
import java.util.TreeSet;


public class _10_ExtractAllUniqueWords {

	public static void main(String[] args) {
		
		Scanner input = new Scanner(System.in);
		System.out.print("Enter text: ");
		String textLine = input.nextLine().toLowerCase();
		String[] textWord = textLine.split("\\W+");
		Set<String> set = new TreeSet<>();
		for (int i = 0; i < textWord.length; i++) {
			set.add(textWord[i]);
		}
		for (String string : set) {
			System.out.print(string + " ");
		}			
	}
}
