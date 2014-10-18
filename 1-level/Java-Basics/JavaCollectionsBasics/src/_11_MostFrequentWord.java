/*
 * Write a program to find the most frequent word in a text and print it, as well as how many times it appears
 *  in format "word -> count". Consider any non-letter character as a word separator. Ignore the character casing.
 *  If several words have the same maximal frequency, print all of them in alphabetical order.
 * */

import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;


public class _11_MostFrequentWord {

	public static void main(String[] args) {
		
		Scanner input = new Scanner(System.in);
		System.out.print("Enter text: ");
		String textLine = input.nextLine().toLowerCase();
		String[] textWords = textLine.split("\\W+");
		Map<String, Integer> wordsCount = new TreeMap<>();
		int maxcount = 0;
		for (String word : textWords) {
			Integer count = wordsCount.get(word);
			if (count == null) {
				count = 0;
			}
			if (count + 1 > maxcount) {
				maxcount = count + 1;
			}
			wordsCount.put(word, count + 1);			
		}
		for (Map.Entry<String, Integer> word : wordsCount.entrySet()) {
			if (word.getValue() == maxcount) {
				System.out.printf("%s -> %d\n", word.getKey(), word.getValue());
			}
		}
	}

}
