import java.io.File;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.PrintStream;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;


public class _09_ListOfProducts {

	public static void main(String[] args) {
		
		ArrayList<Product> productList = new ArrayList<Product>();
		File file = new File("InputProducts.txt");
		Scanner fileReader = null;
		try {
			fileReader = new Scanner(file);
			while (fileReader.hasNextLine()) {
				productList.add(new Product(fileReader.next(), fileReader.nextBigDecimal()));
			}
		} catch (FileNotFoundException e) {
			System.out.println("Error");
		}finally{
			if (fileReader != null) {
				fileReader.close();
			}
		}
		
//		for (int i = 0; i < productList.size(); i++) {
//			
//			for (int j = 0; j < productList.size() - 1; j++) {
//				
//				Product tempProduct = productList[j];
//				if (productList[j].getPrice == productList[j + 1].getPrice) {
//					
//				}
//			}
//		}
		Collections.sort(productList);
		PrintStream fileWriter = null;
		try {
			fileWriter = new PrintStream("OutputProblem9.txt");
			for (Product product : productList) {
				fileWriter.println(product.getPrice() + " " + product.getName());
			}
		} catch (IOException e) {
			System.out.println("Error");
		}finally{
			if (fileWriter != null) {
				fileWriter.close();
			}
		}
	}

}
