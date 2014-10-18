/*
 * Write a program to count how many sequences of two equal bits ("00" or "11")
 * can be found in the binary representation of given integer number n (with overlapping).
 * */

import java.util.Scanner;

public class _08_CountOfEqualBitPairs {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("n = ");
		int number = input.nextInt();
		
		int posLastOneBit = 0;
		int currentPosition = 31;
		int equalBitPairs = 0;
		
		while (posLastOneBit == 0 && currentPosition > 0) {
			
			if ((number & (1 << currentPosition)) != 0) {
				posLastOneBit = currentPosition;
			}
			--currentPosition;			
		}		
		for (int i = 0; i < posLastOneBit; i++) {
			
			int bitPosition_I = number & (1 << i);
			int bitPosition_I_PlusOne = number & (1 << (i + 1));
			
			if ((bitPosition_I != 0 && bitPosition_I_PlusOne != 0) ||
				(bitPosition_I == 0 && bitPosition_I_PlusOne == 0)) {
				
				++equalBitPairs;
			}
		}
			System.out.println("Equal bit pairs: " + equalBitPairs);				
		
	}

}
