/*
 * Write a program to calculate the difference between two dates in number of days.
 * The dates are entered at two consecutive lines in format day-month-year. Days are in range [1…31].
 * Months are in range [1…12]. Years are in range [1900…2100].
 * */

import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.time.temporal.ChronoUnit;
import java.util.Scanner;

public class _07_DaysBetweenTwoDates {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String startDateStr = input.nextLine();
		String endDateStr = input.nextLine();
		LocalDate startDate = LocalDate.parse(startDateStr, DateTimeFormatter.ofPattern("d-MM-yyyy"));
		LocalDate endDate = LocalDate.parse(endDateStr, DateTimeFormatter.ofPattern("d-MM-yyyy"));
		long period = startDate.until(endDate, ChronoUnit.DAYS);
		System.out.print(period);

	}

}
