/*
 * Write a program that enters an array of strings and finds in it all sequences of equal elements.
 * The input strings are given as a single line, separated by a space.
 * */

import java.util.Scanner;


public class _02_SequencesOfEqualStrings {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("Enter line of words: ");
		String wordsLine = input.nextLine();
		String[] wordsSplitted = wordsLine.split(" ");
		System.out.print(wordsSplitted[0]);
		for (int i = 1; i < wordsSplitted.length; i++) {
            
            if (!wordsSplitted[i].equals(wordsSplitted[i - 1])) {
                           
                System.out.print("\n" + wordsSplitted[i]);
                           
            } else { 
            	System.out.print(" " + wordsSplitted[i]); 
            	}
		}
		
	}

}
