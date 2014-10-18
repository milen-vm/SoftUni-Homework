import java.util.Scanner;


public class SumTwoNumbers {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		System.out.print("a = ");
		int a = scan.nextInt();
		System.out.print("b = ");
		int b = scan.nextInt();
		scan.close();
		System.out.println("a + b = " + (a + b));
				
	}

}
