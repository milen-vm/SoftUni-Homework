/*
 * Write a program that enters from the console number n and n strings, 
 * then sorts them alphabetically and prints them. 
 * Note: you might need to learn how to use loops and arrays in Java (search in Internet).
 * */

import java.util.Arrays;
import java.util.Scanner;


public class _08_SortArrayOfStrings {

	public static void main(String[] args) {
		
		Scanner enter = new Scanner(System.in);
		int n = enter.nextInt();
		
		String[] towns = new String[n];
		
		enter.nextLine();
		
		for (int i = 0; i < towns.length; i++) {
			towns[i] = enter.nextLine();
		}
		
		Arrays.sort(towns);
		
		for (int i = 0; i < towns.length; i++) {
			System.out.println(towns[i]);
		}

	}

}
