/*
 * Write a program that enters a positive integer number num and converts and prints it in hexadecimal form.
 * You may use some built-in method from the standard Java libraries.
 * */

import java.util.Scanner;

public class _05_DecimalToHexadecimal {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("Decimal: ");
		int dec = input.nextInt();
		String hex = "";
		
		do {
			int rest = dec % 16;
			switch (rest) {
			case 10:
				hex = 'A' + hex;				
				break;
			case 11:
				hex = 'B' + hex;				
				break;
			case 12:
				hex = 'C' + hex;				
				break;
			case 13:
				hex = 'D' + hex;				
				break;
			case 14:
				hex = 'E' + hex;				
				break;
			case 15:
				hex = 'F' + hex;				
				break;
			default:
				hex = rest + hex;
				break;
			}
			dec = dec / 16;
		} while (dec > 0);
		
		System.out.println("Hexadecimal: " + hex);

	}

}
