/*
 * Write a program to read a text file "Input.txt" holding a sequence of integer numbers, each at a separate line.
 * Print the sum of the numbers at the console. Ensure you close correctly the file in case of exception or
 * in case of normal execution. In case of exception (e.g. the file is missing), print "Error" as a result.
 * */

import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;


public class _08_SumNumberFromTextFile {

	public static void main(String[] args) {
		File file = new File("InputProblem8.txt");
		Scanner fileReader = null;
		int sum = 0;
		try {
			fileReader = new Scanner(file);
			while (fileReader.hasNextInt()) {
				sum += fileReader.nextInt();							
			}		
		} catch (FileNotFoundException e) {
			System.out.println("Error");
		}finally{
			if (fileReader != null) {
				fileReader.close();
				System.out.println(sum);
			}
		}				
	}
}
