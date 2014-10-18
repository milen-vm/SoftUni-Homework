/*
 * In most Poker games, the "full house" hand is defined as three cards of the same face + two cards of the same face,
 * other than the first, regardless of the card's suits. The cards faces are
 * "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" and "A". The card suits are "♣", "♦", "♥" and "♠".
 * Write a program to generate and print all full houses and print their number.
 * */


public class _03_FullHouse {

	public static void main(String[] args) {
		String[] cards = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
		String[] colors = {"♠", "♥", "♦", "♣"};
		int countFullHouse = 0;
		for (int i = 0; i < cards.length; i++) {		//gives a card
			for (int f = 0; f < 4; f++) {			//gives one of four combinations
				String[] fullHouse = new String[5];	//array for the fullhouses
				switch (f) {
				case 0:	
					fullHouse[0] = cards[i] + colors[0];		//add every card to the array
					fullHouse[1] = cards[i] + colors[1];
					fullHouse[2] = cards[i] + colors[2];					
					break;
				case 1:	
					fullHouse[0] = cards[i] + colors[0];
					fullHouse[1] = cards[i] + colors[1];
					fullHouse[2] = cards[i] + colors[3];					
					break;
				case 2:	
					fullHouse[0] = cards[i] + colors[0];
					fullHouse[1] = cards[i] + colors[3];
					fullHouse[2] = cards[i] + colors[2];					
					break;
				case 3:	
					fullHouse[0] = cards[i] + colors[3];
					fullHouse[1] = cards[i] + colors[1];
					fullHouse[2] = cards[i] + colors[2];					
					break;
				}		
				for (int j = 0; j < cards.length; j++) {		//gives a card for the next couple				
					if (j == i) {
						continue;				//skips a card if is equal to the first					
					}
						for (int k = 0; k < colors.length; k++) {		//gives color to the card
							fullHouse[3] = cards[j] + colors[k];		//adding to array
							for (int p = k + 1; p < colors.length; p++) {		//gives next color to the same card
								fullHouse[4] = cards[j] + colors[p];		//adding to array					
								System.out.print("(");
								for (String str : fullHouse) {			//printing fullHouse array					
									System.out.print(str);
								}
								System.out.println(")");
								++countFullHouse;		//increaseing the counter
							}
						}			
				}
			}																									
		}			
		System.out.println(countFullHouse + " full houses");		//printing the counter
	}
}
