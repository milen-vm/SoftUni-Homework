/*
 * Write a program to extract all email addresses from given text. The text comes at the first input line.
 * Print the emails in the output, each at a separate line. Emails are considered to be in format <user>@<host>
 * */

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;


public class _08_ExtractEmails {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("Enter text: ");
		String textLine = input.nextLine();
		String emailRegex = "[\\w-+]+(?:\\.[\\w-+]+)*@(?:[\\w-]+\\.)+[a-zA-Z]{2,7}";
		Pattern emailPattern = Pattern.compile(emailRegex);
		Matcher matcher = emailPattern.matcher(textLine);
		while (matcher.find()) {
			System.out.println(matcher.group());
			
		}

	}

}
