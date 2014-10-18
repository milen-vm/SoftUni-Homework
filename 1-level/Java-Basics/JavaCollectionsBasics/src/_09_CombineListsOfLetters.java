/*
 * Write a program that reads two lists of letters l1 and l2 and combines them:
 * appends all letters c from l2 to the end of l1, but only when c does not appear in l1.
 * Print the obtained combined list. All lists are given as sequence of letters separated by a single space,
 * each at a separate line. Use ArrayList<Character> of chars to keep the input and output lists.
 * */

import java.util.ArrayList;
import java.util.Scanner;


public class _09_CombineListsOfLetters {

	public static void main(String[] args) {
		
		Scanner input = new Scanner(System.in);
		System.out.print("First line: ");
		String firstLineStr = input.nextLine();
		System.out.print("Second line: ");
		String secondLineStr = input.nextLine();
		
		ArrayList<Character> firstLineList = new ArrayList<>();
		for (int i = 0; i < firstLineStr.length(); i += 2) {
			firstLineList.add(firstLineStr.charAt(i));
		}
		ArrayList<Character> secondLineList = new ArrayList<>();
		for (int i = 0; i < secondLineStr.length(); i += 2) {
			secondLineList.add(secondLineStr.charAt(i));
		}
		ArrayList<Character> twoLineList = new ArrayList<>();
		twoLineList.addAll(firstLineList);
		
		for (int i = 0; i < secondLineList.size(); i++) {
			if (firstLineList.contains(secondLineList.get(i))) {
				continue;
			}
			twoLineList.add(secondLineList.get(i));
		}
		for (Character character : twoLineList) {
			System.out.print(character + " ");
		}

	}

}
