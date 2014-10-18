/*
 * Create a class Product to hold products, which have name (string) and price (decimal number).
 * Read from a text file named "Products.txt" a list of product with prices and keep them in a list of products.
 * Each product will be in format name + space + price. You should hold the products in objects of class Product.
 * Read from a text file named "Order.txt" an order of products with quantities. Each order line will be
 * in format product + space + quantity. Calculate and print in a text file "Output.txt" the total price of the order.
 * Ensure you close correctly all used resources.
 * */

import java.io.File;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.PrintStream;
import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.Scanner;


public class _10_OrderOfProducts {

	public static void main(String[] args) {
		
		ArrayList<Product> productList = new ArrayList<Product>();
		File file = new File("InputProducts.txt");
		Scanner fileReader = null;
		PrintStream fileWriter = null;
		try {
			fileReader = new Scanner(file);
			while (fileReader.hasNextLine()) {
				productList.add(new Product(fileReader.next(), fileReader.nextBigDecimal()));
			}
			BigDecimal sumOrder = new BigDecimal("0");
			file = new File("Order.txt");
			fileReader = new Scanner(file);
			while (fileReader.hasNextLine()) {
				BigDecimal quantity = fileReader.nextBigDecimal();
				String currentProduct = fileReader.next();
				for (Product product : productList) {
					if (product.getName().equals(currentProduct)) {
						BigDecimal currentOrder = quantity.multiply(product.getPrice());
						sumOrder = sumOrder.add(currentOrder);
					}
				}
				
			}
			
			fileWriter = new PrintStream("OutputProblem10.txt");
			fileWriter.printf("%.2f", sumOrder);
		} catch (IOException e) {
			System.out.println("Error");
		}finally{
			if (fileReader != null) {
				fileReader.close();
			}
			if (fileWriter != null) {
				fileWriter.close();
			}
		}
	}

}
