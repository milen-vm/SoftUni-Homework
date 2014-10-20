package oneLevShop;

import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.stream.Collectors;

import oneLevShop.exceptions.ProductManagementException;
import oneLevShop.interfaces.Expirable;
import oneLevShop.product.Appliance;
import oneLevShop.product.Computer;
import oneLevShop.product.FoodProduct;
import oneLevShop.product.Product;

public class OneLevShopTest {
	
	public static void main(String[] args){
		FoodProduct cigars = new FoodProduct("420 Blaze it fgt", new BigDecimal("6.90"), 1400, AgeRestriction.ADULT, "10-12-2014");
		Customer pecata = new Customer("Pecata", 17, new BigDecimal("30.00"));
		try {
			PurchaseManager.processPurchase(pecata, cigars);
		} catch (ProductManagementException e) {
			System.err.println(e.getMessage());
		}
								
		Customer gopeto = new Customer("Gopeto", 18, new BigDecimal("0.44"));
		try {
			PurchaseManager.processPurchase(gopeto, cigars);
		} catch (ProductManagementException e) {
			System.err.println(e.getMessage());
		}
		
		ArrayList<Product> products = new ArrayList<Product>();
		products.add(new FoodProduct("Bananas", new BigDecimal("2.49"), 100, AgeRestriction.NONE, "31-10-2014"));
		products.add(new FoodProduct("Potatoes", new BigDecimal("1.49"), 300, AgeRestriction.NONE, "30-10-2014"));
		products.add(new FoodProduct("Vodka", new BigDecimal("9.99"), 200, AgeRestriction.ADULT, "31-10-2015"));
		products.add(new FoodProduct("Wine", new BigDecimal("17.45"), 450, AgeRestriction.ADULT, "31-10-2016"));
		products.add(new FoodProduct("Cigarettes", new BigDecimal("5.60"), 450, AgeRestriction.ADULT, "31-05-2015"));
		products.add(new Computer("Gamer station", new BigDecimal("1789.22"), 20, AgeRestriction.TEENAGER));
		products.add(new Appliance("DVD-ROM", new BigDecimal("30.55"), 50, AgeRestriction.TEENAGER));
		
		Product expirableProduct = products.stream()
				.filter(p -> p instanceof Expirable)
				.map(p -> (FoodProduct)p)
				.sorted((p1, p2) -> p1.getExpirationDate().compareTo(p2.getExpirationDate()))
				.map(p -> (Product)p)
				.findFirst()
				.get();
		
		System.out.println("\nMoust expirable product:");
		System.out.println(expirableProduct);
		
		ArrayList<Product> adultProductsByPrice = (ArrayList<Product>) products.stream()
				.filter(p -> p.getRestriction() == AgeRestriction.ADULT)
				.sorted((p1, p2) -> p1.getPrice().compareTo(p2.getPrice()))
				.collect(Collectors.toList());
		
		System.out.println("\nAdult products sorted by price:");
		adultProductsByPrice.stream().forEach(p -> System.out.println("Name: " + p.getName() + 
				" Price: " + p.getPrice()));
	}
}
