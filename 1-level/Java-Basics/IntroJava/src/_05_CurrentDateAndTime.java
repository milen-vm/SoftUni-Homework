//Create a simple Java program CurrentDateTime.java to print the current date and time.

import java.time.LocalDateTime;

public class _05_CurrentDateAndTime {

	public static void main(String[] args) {
		LocalDateTime today = LocalDateTime.now();	
		System.out.printf("Date: %1$td %1$tB %1$tY\n", today);
		System.out.printf("Time: %1$tH:%1$tM:%1$tS\n ", today);
				
	}

}
