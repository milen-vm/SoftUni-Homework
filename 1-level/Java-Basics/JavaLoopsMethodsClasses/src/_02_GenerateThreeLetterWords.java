/*
 * Write a program to generate and print all 3-letter words consisting of given set of characters.
 * For example if we have the characters 'a' and 'b', all possible words will be "aaa", "aab", "aba",
 * "abb", "baa", "bab", "bba" and "bbb". The input characters are given as string at the first line of the input.
 * Input characters are unique (there are no repeating characters).
 * */

import java.util.Scanner;

public class _02_GenerateThreeLetterWords {

	public static void main(String[] args) {
		
		Scanner input = new Scanner(System.in);
		String charSet;	
		do {
			System.out.print("Characters set: ");
			charSet = input.nextLine();			
		} while (charSet.length() == 0);	
		
		for (int i = 0; i < charSet.length(); i++) {
			
			for (int j = 0; j < charSet.length(); j++) {
				
				for (int f = 0; f < charSet.length(); f++) {
					
					String letter = "" + charSet.charAt(i) + charSet.charAt(j) + charSet.charAt(f);
					System.out.print(letter + " ");
				}
				
			}
			
		}		
	}

}
