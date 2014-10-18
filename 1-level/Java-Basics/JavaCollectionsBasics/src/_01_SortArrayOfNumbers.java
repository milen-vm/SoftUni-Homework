

/*
 * Write a program to enter a number n and n integer numbers and sort and print them.
 * Keep the numbers in array of integers: int[].
 * */

import java.util.Arrays;
import java.util.Scanner;


public class _01_SortArrayOfNumbers {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("n = ");
		int n = input.nextInt();
		int[] numbers = new int[n];
		for (int i = 0; i < numbers.length; i++) {
			System.out.printf("Element %d: ", i + 1);
			numbers[i] = input.nextInt();
		}
		Arrays.sort(numbers);
		for (int i : numbers) {
			System.out.printf("%d ", i);
		}

	}

}
