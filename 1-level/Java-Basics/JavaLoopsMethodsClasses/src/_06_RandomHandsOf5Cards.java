/*
 * Write a program to generate n random hands of 5 different cards form a standard suit of 52 cards.
 * */

import java.util.ArrayList;
import java.util.Random;
import java.util.Scanner;

import javax.print.DocFlavor.INPUT_STREAM;

public class _06_RandomHandsOf5Cards {
	
	public static void main(String[] args) {	
		
		Scanner input = new Scanner(System.in);
		System.out.print("n = ");
		int n = input.nextInt();
		String[] cards = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
		String[] colors = {"♠", "♥", "♦", "♣"};
		String[] deckOfCard = new String[52];
		int index = 0;
		for (int i = 0; i < cards.length; i++) {
			for (int j = 0; j < colors.length; j++) {
				deckOfCard[index] = cards[i] + colors[j];
				++index;
			}
		}	
		Random rnd = new Random();
		for (int i = 0; i < n; i++) {
			ArrayList<String> randomHandCards = new ArrayList<String>();
			do {
				int randomNumber = rnd.nextInt(52);	
				if (randomHandCards.contains(deckOfCard[randomNumber])) {
					continue;
				}
				randomHandCards.add(deckOfCard[randomNumber]);
			} while (randomHandCards.size() < 5);
			for (String card : randomHandCards) {
				System.out.print(card + " ");
			}
			System.out.println();
		}
	}
}
