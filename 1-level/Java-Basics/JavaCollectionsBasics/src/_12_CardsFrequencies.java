/*
 * We are given a sequence of N playing cards from a standard deck. The input consists of several cards (face + suit),
 * separated by a space. Write a program to calculate and print at the console the frequency of each card face
 * in format "card_face -> frequency". The frequency is calculated by the formula appearances / N and is expressed
 * in percentages with exactly 2 digits after the decimal point. The card faces with their frequency should be printed
 * in the order of the card face's first appearance in the input. The same card can appear multiple times in the input,
 * but it's face should be listed only once in the output.
 * */

import java.awt.RenderingHints.Key;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;


public class _12_CardsFrequencies {

	public static void main(String[] args) {
		
		Scanner input = new Scanner(System.in);
		System.out.print("Enter playing cards: ");
		String cardsLine = input.nextLine();
		String[] cards = cardsLine.split("[ ♥♣♦♠]+");
		HashMap<String, Float> cardsFrequency = new HashMap<>();
		for (String card : cards) {
			Float count = cardsFrequency.get(card);
			if (count == null) {
				count = 0f;
			}
			cardsFrequency.put(card, count + 1f);			
		}
		ArrayList<String> appearingOrder = new ArrayList<>();
		for (String card : cards) {
			if (appearingOrder.contains(card)) {
				continue;
			}
			appearingOrder.add(card);
		}
		for (String card : appearingOrder) {
			float appearValue = cardsFrequency.get(card) / cards.length;
			System.out.printf("%S -> %.2f%%\n", card, appearValue * 100);
		}
	}

}
