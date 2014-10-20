package oneLevShop;

import java.math.BigDecimal;

import oneLevShop.exceptions.CustomerOutOfMoneyException;
import oneLevShop.exceptions.CustomerOutOfPermissionException;
import oneLevShop.exceptions.ProductOutOfDateException;
import oneLevShop.exceptions.ProductOutOfStockException;
import oneLevShop.exceptions.ProductManagementException;
import oneLevShop.product.FoodProduct;
import oneLevShop.product.Product;

public final class PurchaseManager {
	public static final int ADULT_AGE = 18;
	
	public static void processPurchase(Customer customer, Product product) throws ProductManagementException {
		if (product.getQuantity() == 0) {
			throw new ProductOutOfStockException("This product is out of stock!");
		}
		
		if (product instanceof FoodProduct) {
			if (((FoodProduct)product).getDaysToExpiration() == 0) {
				throw new ProductOutOfDateException("This product is expired!");
			}
		}
		
		if (customer.getBalace().compareTo(product.getPrice()) < 0) {
			throw new CustomerOutOfMoneyException("You do not have enough money to buy this product!");
		}
		
		if (product.getRestriction() == AgeRestriction.ADULT && 
				customer.getAge() < ADULT_AGE) {
			throw new CustomerOutOfPermissionException("You are too young to buy this product!");
		}
		
		BigDecimal newBalance = customer.getBalace().subtract(product.getPrice());
		customer.setBalace(newBalance);
		
		int newQuantity = product.getQuantity() - 1;
		product.setQuantity(newQuantity);
	}
}
